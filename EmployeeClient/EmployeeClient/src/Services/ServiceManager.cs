// Copyright (c) 2021 Lukin Aleksandr
using Microsoft.Extensions.DependencyInjection;
using EmployeeClient.Controls;
using EmployeeClient.Services;
using EmployeeClient.Services.App;
using EmployeeClient.Services.DockManager;
using EmployeeClient.Services.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient
{
    internal sealed class ServicesManager: GenericManager
    {
        public static void RegistredAll()
        {            
            RegistredServices();
            BuildServiceProvider();            
        }
       
        private static void RegistredServices()
        {
            AddSingleton<IAppService>(new AppService());
            AddSingleton<ISettingsService>(new SettingsService());
            AddSingleton<IDockManagerService>(new DockManagerControl());                       
        }
        
        public static IService GetService<T>()
        {
            IService result = null;           
            result = (IService)GetServiceProvider().GetService<T>();            
            return result;
        }

    }
}
