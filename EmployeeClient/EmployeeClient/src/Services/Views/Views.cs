// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.Views
{
    internal sealed class Views
    {
        public static void Registration()
        {
            ViewManager.Registration<ISettingsView>
                ((ISettingsView)ViewsFactory.Create<ISettingsView>());
            ViewManager.Registration<IEmployeesListView>
                ((IEmployeesListView)ViewsFactory.Create<IEmployeesListView>());
            ViewManager.Registration<IReportView>
                ((IReportView)ViewsFactory.Create<IReportView>());
            ViewManager.Registration<IAboutProgramView>
                ((IAboutProgramView)ViewsFactory.Create<IAboutProgramView>());
        }
    }
}
