// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiriusClient.Views
{
    public partial class ReportView : UserControl, IReportView, INotifyPropertyChanged
    {
        String _Header = "Статистика";

        public String Header 
        {
            get { return _Header; }
            private set 
            { 
                _Header = value;
                OnPropertyChanged("Header");
            }
        }

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
