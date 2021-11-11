// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Services.DockManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Controls
{
    public partial class DockManagerPresenter : UserControl
    {
        public DockManagerPresenter()
        {
            InitializeComponent();
            Init();            
        }

        protected virtual void Init()
        {
            new Task<int>(new Func<int>(() =>
            {
                AddDockManagerControl();
                return 0;
            })).Start(); ;           
        }

        public void AddDockManagerControl()
        {
            var dockManager  = (UserControl)GetDockManagerControl();
            dockManager.Dock = DockStyle.Fill;
            this.Controls.Add(dockManager);
        }

        dynamic GetDockManagerControl()
        {
            return ServicesManager.GetService<IDockManagerService>();
        }
    }
}
