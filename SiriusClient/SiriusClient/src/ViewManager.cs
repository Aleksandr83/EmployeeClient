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
            var services = GetServices();
            services.AddSingleton<IEmployeesListView>(new EmployeesListView());
            services.AddSingleton<IReportView>(new ReportView());
        }

        public static IView GetView<T>()
        {            
            return (IView)GetServiceProvider().GetService<T>();          
        }

        public static void HideAll()
        {
            var views = GetServiceProvider().GetServices<IView>();
            foreach (var view in views) view.Hide();
        }

        public static void ShowAll()
        {
            var views = GetServiceProvider().GetServices<IView>();
            foreach (var view in views) view.Show();
        }
    }
}
