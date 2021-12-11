// Copyright (c) 2021 Lukin Aleksandr
using alg.Services.Settings;
using alg.Types;
using alg.Types.Controls;
using alg.Types.Controls.DataGrid;
using alg.Types.Generic;
using EmployeeClient.Configuration;
using EmployeeClient.Data.Models;
using EmployeeClient.Data.Repositories;
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
    public partial class EmployeeDataGridViewControl : UserControl, IUserControl
    {
        private int DEFAULT_TIMEOUT = 10000;
        private int MIN_TIMEOUT     = 1000;

        private const String SCHEMA_NAME = "EmployeeList";

        BindingList<Employee> Employees  = new BindingList<Employee>();
        EmployeeRepository    Repository = new EmployeeRepository();        

        public EmployeeDataGridViewControl()
        {
            InitializeComponent();
            new DataGridInitializator<EmployeeDataGridViewControl>
                (GetDataGridControl(), Employees, SCHEMA_NAME)
                .Init();
                                            
        }

        private IDataGridControl GetDataGridControl() => this.dataGridViewControl1;        
                
        private ISettingsService GetSettingsService()        
            => (ISettingsService)ServicesManager.GetService<ISettingsService>();

        #region Update
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
                                Invoke(new Action<IList<Employee>, Employee>((x, y)
                                     => { x.Add(y); }), Employees, item);
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
        #endregion Update        

    }
}
