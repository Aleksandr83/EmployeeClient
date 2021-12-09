// Copyright (c) 2021 Lukin Aleksandr
using alg.Data.Types;
using EmployeeClient.Data.Repositories;
using EmployeeClient.Services.Views;
using EmployeeClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient
{
    internal sealed class DbManager 
    {        
        static IConnectionString _PrimaryConnectionString;

        public static bool IsConnected() => IsTestConnection();

        public static IConnectionString GetPrimaryConnectionString() 
            => _PrimaryConnectionString;
             

        public static void SetPrimaryConnectionString(IConnectionString connectionString)
        {
            _PrimaryConnectionString = connectionString;          
        }

        public static bool IsTestConnection()
        {
            return new EmployeeRepository()?.IsTestConnection() ?? false;
        }

        public static void Connected()
        {
            if (IsConnected())
            {
                ViewManager.ShowAll<INormalView>();
                ViewManager.HideAll<ISettingsView>();
            }            
        }
        
        public static void Disconnected()
        {
            if (IsConnected())
            {

            }
            ViewManager.ShowAll<ISettingsView>();
            ViewManager.HideAll<INormalView>();
        }
    }
}
