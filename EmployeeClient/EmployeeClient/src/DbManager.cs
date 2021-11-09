// Copyright (c) 2021 Lukin Aleksandr
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
        public static bool IsConnected() => _IsConnected;   

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
