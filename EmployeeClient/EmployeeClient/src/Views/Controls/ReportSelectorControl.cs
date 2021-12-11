// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls;
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

namespace EmployeeClient.Controls
{
    public partial class ReportSelectorControl : UserControl, IUserControl
    {
        public ReportSelectorControl()
        {
            InitializeComponent();
            ResourcesManagerHelper<ReportSelectorControl>
                .UpdateControlsHeaders(this);
        }
    }
}
