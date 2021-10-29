// Copyright (c) 2021 Lukin Aleksandr
using Microsoft.Extensions.DependencyInjection;
using SiriusClient.Services;
using SiriusClient.Services.Views;
using SiriusClient.Views;
using SiriusClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient
{
    internal sealed class ViewManager : GenericManager
    {
        public static void RegistredAll()
        {
            RegistredViews();
            BuildServiceProvider();           
        }

        private static void RegistredViews()
        {           
            AddSingleton<IEmployeesListView>(new EmployeesListView());
            AddSingleton<IReportView>(new ReportView());            
        }

        public static IView GetView<T>()
        {          
            return (IView)GetServiceProvider().GetService<T>();          
        }
        
        public static void HideAll<T>() where T : IView
        {
            var views = GetAll<T>();
            foreach (var view in views) view.Hide();
        }

        public static void ShowAll<T>() where T : IView
        {
            var views = GetAll<T>();
            foreach (var view in views) view.Show();
        }
    }
}
