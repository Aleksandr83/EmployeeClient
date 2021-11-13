// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Services;
using EmployeeClient.Types;
using EmployeeClient.Types.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient
{
    internal sealed class CommandsManager : GenericManager
    {
        public static ICommand GetCommandByName(string commandName)
        {       
            return GetAll<ICommand>()?
                .Where(x => x.Name == commandName)?
                .FirstOrDefault();            
        }
    }
}
