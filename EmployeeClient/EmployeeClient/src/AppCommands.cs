// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Services.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient
{
    internal sealed class AppCommands
    {
        public static void ConnectionToDB(object parameter)
        {
            (ServicesManager.GetService<IDbService>() as IDbService)?
                .PrimaryDbConfiguration?.Save();

            
        }

    }
}
