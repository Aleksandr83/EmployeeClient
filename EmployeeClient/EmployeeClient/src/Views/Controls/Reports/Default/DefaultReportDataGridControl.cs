// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls;
using alg.Types.Controls.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeClient.Controls.Reports.Default
{
    public partial class DefaultReportDataGridControl : UserControl, IUserControl
    {

        private const String SCHEMA_NAME = "Report.Default";

        //BindingList<>  Items = new BindingList<>();

        public DefaultReportDataGridControl()
        {
            InitializeComponent();
            new DataGridInitializator<DefaultReportDataGridControl>
                (GetDataGridControl(), null, SCHEMA_NAME)
                .Init();
        }

        private IDataGridControl GetDataGridControl() => this.dataGridViewControl1;


    }
}
