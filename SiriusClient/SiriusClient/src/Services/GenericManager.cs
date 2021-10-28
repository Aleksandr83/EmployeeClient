// Copyright (c) 2021 Lukin Aleksandr
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient.Services
{
    internal class GenericManager
    {
        static ServiceCollection _Services = new ServiceCollection();
        static ServiceProvider   _ServiceProvider;

        protected static ServiceCollection GetServices() => _Services;
        protected static ServiceProvider GetServiceProvider() => _ServiceProvider;
        protected static void BuildServiceProvider() => _ServiceProvider = GetServices().BuildServiceProvider();

    }
}
