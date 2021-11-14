﻿// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services
{
    internal interface IReffer
    {
        Type GetRefferItemType();
        IList<dynamic> GetRefferItems();
    }
}
