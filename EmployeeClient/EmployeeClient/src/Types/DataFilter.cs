// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Types
{
    internal class DataFilter<T> 
        : alg.Types.Controls.DataFilter<T> 
    {
        public void BindingHeader(Control control, String propertyName)
        {
            control.DataBindings
                .Add(propertyName, this, "Header");
        }

        public void BindingValue(Control control, String propertyName)
        {
            control.DataBindings
                .Add(propertyName, this, "Value");
        }
    }
}
