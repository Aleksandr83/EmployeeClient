// Copyright (c) 2021 Lukin Aleksandr
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services
{
    internal class GenericManager
    {
        static IList<object>     _Cache    = new List<object>();
        static ServiceCollection _Services = new ServiceCollection();
        static ServiceProvider   _ServiceProvider;

        protected static ServiceCollection GetServices() => _Services;
        protected static ServiceProvider GetServiceProvider() => _ServiceProvider;
        protected static void BuildServiceProvider() => _ServiceProvider = GetServices().BuildServiceProvider();
        protected static void AddSingleton<T>(T value) where T : class
        {
            var services = GetServices();
            services?.AddSingleton<T>(value);
            ValueСaching(value);
        }

        public static void Registration<T>(T service) where T : class
        {
            AddSingleton<T>(service);
            BuildServiceProvider();
        }

        private static void ValueСaching(object value)
        {
            _Cache?.Add(value);
        }

        private static IEnumerable<object> GetCachingValues() => (IEnumerable<object>)_Cache;
        public static IEnumerable<T> GetAll<T>()
        {
            IList<T> result = new List<T>();
            var values = GetCachingValues();
            foreach (var value in values)
            {
                if (value is T)
                    result?.Add((T)value);
            }
            return result;
            
        }

        //public static IEnumerable<T> GetAll<T>()
        //{        
        //    return GetServiceProvider().GetServices<T>();
        //}
    }
}
