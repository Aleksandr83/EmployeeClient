// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls;
using EmployeeClient.Helpers;
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
    public partial class HDataRangeControl : UserControl, IUserControl
    {

        #region ResourceManager
        static readonly ResourceManager _ResourceManager = new ResourceManager(typeof(HDataRangeControl));
        static ResourceManager GetResourceManager() => _ResourceManager;
        static String GetResourceString(String name) => GetResourceManager()?.GetString(name);
        #endregion ResourceManager

        public HDataRangeControl()
        {
            InitializeComponent();
            //ResourcesManagerHelper.UpdateControlsHeaders(this, new Func<string, string>((x) => { return GetResourceString(x); }));
        }
    }
}
