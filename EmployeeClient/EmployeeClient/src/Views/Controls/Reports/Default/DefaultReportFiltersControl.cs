// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls;
using EmployeeClient.Helpers;
using System;
using System.Windows.Forms;

namespace EmployeeClient.Controls.Reports.Default
{
    public partial class DefaultReportFiltersControl : UserControl, IUserControl
    {       

        public DefaultReportFiltersControl()
        {
            InitializeComponent();
            ResourcesManagerHelper<DefaultReportFiltersControl>
                .UpdateControlsHeaders(this);
        }

        public new void Update()
        {
            base.Update();
        }
    }
}
