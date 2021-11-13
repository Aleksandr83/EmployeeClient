// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Data.Types;
using EmployeeClient.Helpers;
using EmployeeClient.Services.DB;
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
        static bool _IsConnected = false;
        static IConnectionString _PrimaryConnectionString;

        public static bool IsConnected() => _IsConnected;

        public static IConnectionString GetPrimaryConnectionString() 
            => _PrimaryConnectionString;
        public static void SetPrimaryConnectionString(IConnectionString connectionString)
        {
            _PrimaryConnectionString = connectionString;          
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
            ViewManager.ShowAll<ISettingsView>();
            ViewManager.HideAll<INormalView>();
        }
    }
}
