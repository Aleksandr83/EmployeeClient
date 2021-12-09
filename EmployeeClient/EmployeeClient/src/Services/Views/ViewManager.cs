// Copyright (c) 2021 Lukin Aleksandr
using Microsoft.Extensions.DependencyInjection;
using EmployeeClient.Services;
using EmployeeClient.Services.Views;
using EmployeeClient.Views;
using EmployeeClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alg.Types;
using EmployeeClient.Services.DockManager;

namespace EmployeeClient
{
    internal sealed class ViewManager : GenericManager
    {
        public static IView GetView<T>()
        {          
            return (IView)GetServiceProvider().GetService<T>();          
        }
        
        public static void HideAll<T>() where T : IView
        {
            var views = GetAll<T>();
            var dockManagerService = GetDockManagerService(); 
            
            foreach (var view in views)
                dockManagerService.HideView(view);              
        }

        public static void ShowAll<T>() where T : IView
        {
            var views = GetAll<T>().Reverse();
            var dockManagerService = GetDockManagerService();

            foreach (var view in views)
                dockManagerService.ShowView(view);            
        }

        private static IDockManagerService GetDockManagerService()
        {
            return (IDockManagerService)ServicesManager
                .GetService<IDockManagerService>();            
        }
    }
}
