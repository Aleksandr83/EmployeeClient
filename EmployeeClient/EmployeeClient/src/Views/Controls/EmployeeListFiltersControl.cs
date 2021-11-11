// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Helpers;
using EmployeeClient.Types.Controls;
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
    public partial class EmployeeListFiltersControl : UserControl, IUserControl
    {

        #region ResourceManager
        static readonly ResourceManager _ResourceManager = new ResourceManager(typeof(EmployeeListFiltersControl));
        static ResourceManager GetResourceManager() => _ResourceManager;
        static String GetResourceString(String name) => GetResourceManager()?.GetString(name);
        #endregion ResourceManager

        public EmployeeListFiltersControl()
        {
            InitializeComponent();
            ResourcesManagerHelper.UpdateControlsHeaders(this, new Func<string, string>((x) => { return GetResourceString(x); }));
        }
    }
}
