// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Types
{
    internal class DataBindBroker<T> 
        : alg.Types.DataBindBroker<T>
    {
        internal void Bind(Control control, String propertyName)
        {
            control.DataBindings
                .Add(propertyName, this, "Value");
        }
    }
}
