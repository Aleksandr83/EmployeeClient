// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient
{
    internal static class Program
    {        
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            App.Init();
            Application.Run(new MainForm());
            
        }      
       
    }
}
