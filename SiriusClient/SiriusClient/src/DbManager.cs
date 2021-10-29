// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Services.Views;
using SiriusClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient
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
