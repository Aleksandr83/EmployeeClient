// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiriusClient
{
    internal static class Program
    {        
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Init();
            Application.Run(new MainForm());            
        }

        static void Init()
        {
            ServicesManager.RegistredAll();
            ViewManager.RegistredAll();
        }
    }
}
