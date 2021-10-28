// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiriusClient.Views
{
    public partial class EmployeesListView : UserControl, IEmployeesListView
    {
        public EmployeesListView()
        {
            InitializeComponent();
        }
       
    }
}
