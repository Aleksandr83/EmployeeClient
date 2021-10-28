// Copyright (c) 2021 Lukin Aleksandr
using Microsoft.Extensions.DependencyInjection;
using SiriusClient.Services;
using SiriusClient.Services.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient
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
            var services = GetServices();
            services.AddSingleton<ISettingsService>(new SettingsService());
        }
        
        public static IService GetService<T>()
        {            
            return (IService)GetServiceProvider().GetService<T>();
        }

    }
}
