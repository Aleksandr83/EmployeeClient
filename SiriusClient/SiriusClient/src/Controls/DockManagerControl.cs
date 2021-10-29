// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Services.DockManager;
using SiriusClient.Services.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiriusClient.Controls
{
    public partial class DockManagerControl : UserControl, IDockManagerService
    {
        BindingList<IView> Views = new BindingList<IView>();

        public DockManagerControl()
        {
            InitializeComponent();     
        }

        private TabControl  GetTabControl() => tabControl1;
        private TabPage     CreateTabPage() => new TabPage();

        private void SetContentTabPage(TabPage tabPage,IView view)
        {            
            (view as UserControl).Dock = DockStyle.Fill;
            tabPage.Text = view.Header;
            tabPage.Controls.Add((UserControl)view);            
        }

        private void InsertPageInTabControl(TabControl tabControl,TabPage tabPage)
        {
            tabControl.Controls.Add(tabPage);
        }

        internal void AddView(IView view)
        {
            var tabControl = GetTabControl();
            var tabPage = CreateTabPage();            
            SetContentTabPage(tabPage,view);
            InsertPageInTabControl(tabControl, tabPage);          
        }

        void IDockManager.AddView(IView view)
        {
            this.AddView(view);
        }
    }
}
