// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Services.App;
using EmployeeClient.Services.DockManager;
using EmployeeClient.Services.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient
{
    internal static class Program
    {        
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Init();
            Application.Run(new MainForm());            
        }

        static void Init()
        {
            ServicesManager.RegistredAll();
            InitConfiguration();
            ViewManager.RegistredAll();
            //DbManager.Disconnected();
            DbManager.Connected(); // temp
            AttachViewsInDockManager();
        }

        static void InitConfiguration()
        {
            (ServicesManager
                .GetService<IAppService>() as IAppService)?
                .InitConfiguration();            
        }
        
        static void AttachViewsInDockManager()
        {
            var views = ViewManager.GetAll<IView>();
            var dockManager = (IDockManagerService)ServicesManager
                .GetService<IDockManagerService>();
            foreach (var view in views) 
                dockManager.AddView(view);
        }
    }
}
