// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Views;
using EmployeeClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.Views
{
    internal sealed class ViewsFactory
    {
        public static IView Create<T>()
        {            
            if (typeof(T) == typeof(ISettingsView))
                return (IView)Activator.CreateInstance(typeof(SettingsView));
            if (typeof(T) == typeof(IEmployeesListView))
                return (IView)Activator.CreateInstance(typeof(EmployeesListView));
            if (typeof(T) == typeof(IReportView))
                return (IView)Activator.CreateInstance(typeof(ReportView));
            if (typeof(T) == typeof(IAboutProgramView))
                return (IView)Activator.CreateInstance(typeof(AboutProgramView));
            return null;
        }
    }
}
