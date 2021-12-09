// Copyright (c) 2021 Lukin Aleksandr
using alg.Services.Settings;
using alg.Types;
using alg.Types.Controls.DataGrid;
using alg.Types.Controls.DataGrid.Schema;
using alg.Types.Generic;
using EmployeeClient.Configuration;
using EmployeeClient.Data.Models;
using EmployeeClient.Data.Repositories;
using EmployeeClient.Services.ColumnsConfiguration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Controls
{
    public partial class EmployeeDataGridViewControl : UserControl
    {
        private int DEFAULT_TIMEOUT = 10000;
        private int MIN_TIMEOUT     = 1000;

        ColumnsSchema         _ColumnsSchema;
        BindingList<Employee> Employees  = new BindingList<Employee>();
        EmployeeRepository    Repository = new EmployeeRepository();


        #region ResourceManager
        static readonly ResourceManager _ResourceManager = new ResourceManager(typeof(EmployeeDataGridViewControl));
        static ResourceManager GetResourceManager() => _ResourceManager;
        static String GetResourceString(String name) => GetResourceManager().GetString(name);
        #endregion ResourceManager

        public EmployeeDataGridViewControl()
        {
            InitializeComponent();
            Init();
            Update(); // temp           
        }

        private IDataGridControl GetDataGridControl() => this.dataGridViewControl1;

        private void Init()
        {
            InitColumnsSchema();
            var dataGrid = GetDataGridControl();
            dataGrid?.SetReadOnly(true);
            dataGrid?.SetAutoGenerateColumns(false);
            dataGrid?.SetAllowUserAddRows(false);
            dataGrid?.SetColumnsSchema(GetColumnsSchema());            
            dataGrid?.CreateColumns();
            dataGrid?.SetDataSource(Employees);
        }

        private void InitColumnsSchema()
        {
            var columnsConfigurationService = GetColumnsConfigurationService();
            var columnsSchema = SetColumnsSchema(columnsConfigurationService?
                .GetColumnsSchemaByName("EmployeeList"));
            var columns = columnsSchema?.Columns;
            foreach (var column in columns)
            {
                if (column == null) continue;
                column.Header = GetColumnNameByHeaderId(column.HeaderId);
            }
        }

        private String GetColumnNameByHeaderId(String headerId)
        {
            return GetResourceString(headerId);            
        }

        private void EmployeeListUpdate()
        {
            var task = new Task<int>(new Func<int>(() =>
            {
                var settingsService = GetSettingsService();
                int timeout = settingsService.GetIntValue
                    (
                        SettingsSections.SETTINGS_SECTION_DB,
                        SettingsNames.SETTINGS_DB_TIMEOUT,
                        DEFAULT_TIMEOUT
                    );
                if (timeout < MIN_TIMEOUT) timeout = MIN_TIMEOUT;

                Thread th = new Thread(() =>
                {
                    lock (this)
                    {
                        Employees.Clear();
                        dynamic items = Repository?.GetAll();
                        foreach (var item in items ?? List.Empty<Employee>())
                            if (!InvokeRequired)
                                Employees.Add(item);
                            else
                            {
                                Invoke(new Action<IList<Employee>,Employee>((x,y)
                                    => {x.Add(y); }), Employees, item);
                            }
                    }
                });

                th.Start();
                th.Join(DEFAULT_TIMEOUT);
                th.Abort();
                return 0;
            }));
            task.Start();
        }

        public new void Update()
        {
            base.Update();
            EmployeeListUpdate();
        }

        private ColumnsSchema GetColumnsSchema() => _ColumnsSchema;

        private ColumnsSchema SetColumnsSchema(ColumnsSchema columnsSchema)
        {
            return _ColumnsSchema = columnsSchema;
        }

        private IColumnsConfigurationService GetColumnsConfigurationService() =>
            (IColumnsConfigurationService)ServicesManager
                .GetService<IColumnsConfigurationService>();

        private ISettingsService GetSettingsService()
        {
            return (ISettingsService)ServicesManager
                .GetService<ISettingsService>();
        }
    }
}
