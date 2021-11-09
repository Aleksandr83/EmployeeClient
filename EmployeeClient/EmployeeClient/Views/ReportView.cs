// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Views
{
    public partial class ReportView : UserControl, IReportView, INotifyPropertyChanged
    {
        #region Header
        String _Header = GetResourceString("View.Header");

        public String Header
        {
            get { return _Header; }
            private set
            {
                _Header = value;
                OnPropertyChanged("Header");
            }
        }
        #endregion Header

        #region ResourceManager
        static readonly ResourceManager _ResourceManager = new ResourceManager(typeof(ReportView));
        static ResourceManager GetResourceManager() => _ResourceManager;
        static String GetResourceString(String name) => GetResourceManager().GetString(name);
        #endregion ResourceManager

        public ReportView()
        {
            InitializeComponent();
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion PropertyChanged
    }
}
