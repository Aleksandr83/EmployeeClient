// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Repositories
{
    internal class RepositoryContext<T> : DbContext where T : class
    {
        public RepositoryContext(String connectionString)
            :base(connectionString)
        {
            Database.SetInitializer<RepositoryContext<T>>(null);
        }
    }
}
