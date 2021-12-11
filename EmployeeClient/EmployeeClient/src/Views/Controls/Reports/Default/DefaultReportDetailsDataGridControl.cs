// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls;
using alg.Types.Controls.DataGrid;
using EmployeeClient.Helpers;
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
    public partial class DefaultReportDetailsDataGridControl : UserControl, IUserControl
    {
        private const String SCHEMA_NAME = "Report.Details.Default";

        //BindingList<>  Items = new BindingList<>();

        public DefaultReportDetailsDataGridControl()
        {
            InitializeComponent();
            UpdateControlsHeaders();
            InitDataGridColumns();
        }

        private void UpdateControlsHeaders()
            => ResourcesManagerHelper<DefaultReportDetailsDataGridControl>
            .UpdateControlsHeaders(this);

        private void InitDataGridColumns()
            => new DataGridInitializator<DefaultReportDetailsDataGridControl>
                (GetDataGridControl(), null, SCHEMA_NAME)
                .Init();

        private IDataGridControl GetDataGridControl() => this.dataGridViewControl1;
    }
}
