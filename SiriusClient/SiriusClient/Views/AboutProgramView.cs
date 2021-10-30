// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Views.Interfaces;
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

namespace SiriusClient.Views
{
    public partial class AboutProgramView : UserControl, IAboutProgramView
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
        static readonly ResourceManager _ResourceManager = new ResourceManager(typeof(AboutProgramView));
        static ResourceManager GetResourceManager() => _ResourceManager;
        static String GetResourceString(String name) => GetResourceManager().GetString(name);
        #endregion ResourceManager

        public AboutProgramView()
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
