// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Data.Models;
using EmployeeClient.Services.ColumnsConfiguration;
using EmployeeClient.Types.Controls.DataGrid;
using EmployeeClient.Types.Controls.DataGrid.Schema;
using EmployeeClient.Types.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Controls
{
    public partial class EmployeeDataGridViewControl : UserControl
    {        
        ColumnsSchema _ColumnsSchema;
        BindingList<Employee> Employees = new BindingList<Employee>();

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
            dataGrid?.SetColumnsSchema(GetColumnsSchema());
            dataGrid?.CreateColumns();
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

        public new void Update()
        {
            base.Update();  
            
        }

        private ColumnsSchema GetColumnsSchema() => _ColumnsSchema;

        private ColumnsSchema SetColumnsSchema(ColumnsSchema columnsSchema)
        {
            return _ColumnsSchema = columnsSchema;
        }

        private IColumnsConfigurationService GetColumnsConfigurationService() =>
            (IColumnsConfigurationService)ServicesManager
                .GetService<IColumnsConfigurationService>();


    }
}
