// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Configuration;
using EmployeeClient.Controls;
using EmployeeClient.Services.App;
using EmployeeClient.Services.Commands;
using EmployeeClient.Services.DB;
using EmployeeClient.Services.DockManager;
using EmployeeClient.Services.Settings;
using EmployeeClient.Services.Views;
using EmployeeClient.Types.Commands;
using EmployeeClient.Views;
using EmployeeClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient
{
    internal sealed class App
    {
        public static void Init()
        {
            RegisteringServices();
            InitConfiguration();
            RegisteringCommands();
            RegisteringViews();
            //DbManager.Disconnected();
            DbManager.Connected(); // temp
            AttachViewsInDockManager();
        }

        private static void InitConfiguration()
        {
            (ServicesManager
                .GetService<IAppService>() as IAppService)?
                .InitConfiguration();
        }

        private static void AttachViewsInDockManager()
        {
            var views = ViewManager.GetAll<IView>();
            var dockManager = (IDockManagerService)ServicesManager
                .GetService<IDockManagerService>();
            foreach (var view in views)
                dockManager.AddView(view);
        }

        private static void RegisteringViews()
        {
            ViewManager.Registration<ISettingsView>(new SettingsView());
            ViewManager.Registration<IEmployeesListView>(new EmployeesListView());
            ViewManager.Registration<IReportView>(new ReportView());
            ViewManager.Registration<IAboutProgramView>(new AboutProgramView());
        }

        private static void RegisteringServices()
        {
            ServicesManager.Registration<IAppService>(new AppService());
            ServicesManager.Registration<ISettingsService>(new SettingsService());
            ServicesManager.Registration<ICommandsService>(new CommandsService());
            ServicesManager.Registration<IDbService>(new DbService());
            ServicesManager.Registration<IDockManagerService>(new DockManagerControl());
        }

        private static void RegisteringCommands()
        {          
            var commandsService = (ICommandsService)ServicesManager
                .GetService<ICommandsService>();
            commandsService.CommandRegistration(new Command
                (
                    CommandsNames.CONNECTED_TO_DB,                    
                    AppCommands.ConnectionToDB
                ));
        }
    }
}
