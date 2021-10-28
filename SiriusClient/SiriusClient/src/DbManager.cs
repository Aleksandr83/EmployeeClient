// Copyright (c) 2021 Lukin Aleksandr
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
                ViewManager.ShowAll();
            }
        }

        public static void Disconnected()
        {
            ViewManager.HideAll();
        }
    }
}
