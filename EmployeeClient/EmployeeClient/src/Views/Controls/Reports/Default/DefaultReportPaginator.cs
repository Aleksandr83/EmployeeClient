// Copyright (c) 2021 Lukin Aleksandr
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
    public partial class DefaultReportPaginator : UserControl
    {
        public DefaultReportPaginator()
        {
            InitializeComponent();            
        }
        private PaginatorControl GetPaginatorControl() => paginatorControl1;
    }
}
