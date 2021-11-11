// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Types.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.Commands
{
    internal class CommandsService : ICommandsService
    {
        public ICommand GetCommandByName(string commandName)
        {
            return CommandsManager.GetCommandByName(commandName);
        }

        public void CommandRegistration(ICommand command)
        {
            CommandsManager.Registration<ICommand>(command);
        }
    }
}
