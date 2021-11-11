// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Services.DockManager;
using EmployeeClient.Services.Views;
using System;
using System.Collections;
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
    public partial class DockManagerControl : UserControl, IDockManagerService
    {
        BindingList<IView> Views = new BindingList<IView>();

        public DockManagerControl()
        {
            InitializeComponent();     
        }

        private TabControl  GetTabControl() => tabControl1;
        private TabPage     CreateTabPage() => new TabPage();
        private TabPage     GetActiveTabPage() => GetTabControl()?.SelectedTab;        

        private IView GetContentTabPage(TabPage tabPage)
        {
            var controls = new ArrayList(tabPage?.Controls);
            return (IView)controls?.ToArray()?
                .Where(control => control is IView)?.FirstOrDefault();
        }

        private void SetContentTabPage(TabPage tabPage,IView view)
        {
            if (tabPage == null) return;            
            tabPage.Text = view?.Header;
            if (view != null)
            {
                tabPage.Controls.Add((UserControl)view);
                (view as UserControl).Dock = DockStyle.Fill;
            }
        }

        private void InsertPageInTabControl(TabControl tabControl,TabPage tabPage)
        {
            tabControl?.Controls?.Add(tabPage);
        }

        internal void AddView(IView view)
        {
            var tabControl = GetTabControl();
            var tabPage    = CreateTabPage();            
            SetContentTabPage(tabPage,view);
            InsertPageInTabControl(tabControl, tabPage);          
        }

        void IDockManager.AddView(IView view)
        {
            this.AddView(view);
        }
        IView IDockManager.GetActiveView()
        {            
            return GetContentTabPage(GetActiveTabPage());
        }
    }
}
