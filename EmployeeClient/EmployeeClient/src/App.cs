// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Configuration;
using EmployeeClient.Controls;
using EmployeeClient.Data.Models.Reffers;
using EmployeeClient.Data.Repositories;
using EmployeeClient.Services.App;
using EmployeeClient.Services.ColumnsConfiguration;
using EmployeeClient.Services.Commands;
using EmployeeClient.Services.DB;
using EmployeeClient.Services.DockManager;
using EmployeeClient.Services.Reffers;
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
            RegisteringReffers();
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
            ServicesManager.Registration<IReffersService>(new ReffersService());    
            ServicesManager.Registration<IColumnsConfigurationService>(new ColumnsConfigurationService());
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

        private static void RegisteringReffers()
        {
            var reffersService = (IReffersService)ServicesManager
                .GetService<IReffersService>();
            reffersService.RefferRegistration
                (new RefferRepository<Post>(ReffersNames.REFFER_NAME_POSTS));
            reffersService.RefferRegistration
                (new RefferRepository<Status>(ReffersNames.REFFER_NAME_STATUSES));
            reffersService.RefferRegistration
                (new RefferRepository<Departament>(ReffersNames.REFFER_NAME_DEPARTAMENTS));
        }
    }
}
