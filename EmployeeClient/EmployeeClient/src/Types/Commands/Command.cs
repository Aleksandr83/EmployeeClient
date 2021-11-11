// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Types.Commands
{
    internal class Command : ICommand
    {
        String _Name;
        String _Gesture;
        Action<dynamic> Action { get; set; }
        public Command() { }
        public Command(String commandName,Action<dynamic> action, String gesture = null)
        {
            _Name    = commandName;            
            _Gesture = gesture;
            Action   = (Action<dynamic>)action;
        }

        public string Name => _Name;
        public string Gesture => _Gesture;      

        event EventHandler System.Windows.Input.ICommand.CanExecuteChanged
        {
            add
            {
                //throw new NotImplementedException();
            }

            remove
            {
                //throw new NotImplementedException();
            }
        }

        bool System.Windows.Input.ICommand.CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {           
            Action?.Invoke(parameter);
        }      

    }
}
