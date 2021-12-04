// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Configuration;
using EmployeeClient.Data.Models.Reffers;
using EmployeeClient.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.Reffers
{
    internal sealed class ReffersFactory
    {
        public static IReffer Create<T>() where T : class
        {           
            if (typeof(T) == typeof(Post))
                return new RefferRepository<Post>(ReffersNames.REFFER_NAME_POSTS);
            if (typeof(T) == typeof(Status))
                return new RefferRepository<Status>(ReffersNames.REFFER_NAME_STATUSES);
            if (typeof(T) == typeof(Departament))
                return new RefferRepository<Departament>(ReffersNames.REFFER_NAME_DEPARTAMENTS);
            return null;
        }
    }
}
