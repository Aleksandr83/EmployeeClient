// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Repositories
{
    internal abstract class GenericRepository<T> : DbContext where T : class
    {

        public GenericRepository()
        {            
            Database.SetInitializer<GenericRepository<T>>(null);
        }

        protected abstract String GetConnectionString();

        IList<T> GetAll()
        {
            IList<T>  result = null;

            return result;
        }
    }
}
