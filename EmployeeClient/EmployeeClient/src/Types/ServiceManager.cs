// Copyright (c) 2021 Lukin Aleksandr
using Microsoft.Extensions.DependencyInjection;
using EmployeeClient.Controls;
using EmployeeClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeClient.Types;

namespace EmployeeClient
{
    internal sealed class ServicesManager: GenericManager
    {
        public static IService GetService<T>()
        {
            IService result = null;           
            result = (IService)GetServiceProvider().GetService<T>();            
            return result;
        }
    }
}
