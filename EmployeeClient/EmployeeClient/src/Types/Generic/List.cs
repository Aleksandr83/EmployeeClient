﻿// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Types.Generic
{
    internal class List
    {        
        public static IList<T> Empty<T>() => new List<T>();
    }
}