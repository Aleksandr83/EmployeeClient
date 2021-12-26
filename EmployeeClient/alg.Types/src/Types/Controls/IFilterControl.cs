// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Types.Controls
{
    public interface IFilterControl
    {
        Type   GetValueType();
        String GetFilterName();

        bool   Validate();
    }

    public interface IFilterControl<T> : IFilterControl
    {
        T      GetValue();        
    }
}
