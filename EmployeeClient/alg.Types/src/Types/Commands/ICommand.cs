// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Types.Commands
{
    public interface ICommand : System.Windows.Input.ICommand
    {
        String Name     { get; }
        String Gesture  { get; }

        void Execute(object parameter);        
    }
}
