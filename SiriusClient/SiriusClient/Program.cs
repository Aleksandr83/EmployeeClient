// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Services.App;
using SiriusClient.Services.DockManager;
using SiriusClient.Services.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiriusClient
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
            var appService = (IAppService)ServicesManager
                .GetService<IAppService>();
            appService.CreateConfigurationDataDir();
            appService.CreateConfigurationFile();
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
