// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Repositories
{
    internal abstract class Repository<T> : DbContext where T : class
    {

        public Repository()
        {            
            Database.SetInitializer<Repository<T>>(null);
        }

        protected abstract String GetConnectionString();

        IList<T> GetAll()
        {
            IList<T>  result = null;

            return result;
        }
    }
}
