// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Controls.Reports.Default
{
    public partial class DefaultReportControl 
        : UserControl, IUserControl
    {
        public DefaultReportControl()
        {
            InitializeComponent();
        }

        private IUserControl GetDataGridControl()
            => defaultReportDataGridControl1;

        private IUserControl GetDetailsDataGridControl()
            => defaultReportDetailsDataGridControl1;

        public new void Update()
        {
            GetDataGridControl()?.Update();
            GetDetailsDataGridControl()?.Update();
            base.Update();
        }
    }
}
