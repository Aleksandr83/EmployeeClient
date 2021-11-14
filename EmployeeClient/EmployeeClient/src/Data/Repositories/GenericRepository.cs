﻿// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Repositories
{
    internal abstract class GenericRepository<T> where T : class
    {
        public GenericRepository()
        {           
        }

        protected abstract String GetConnectionString();
        protected abstract String GetSpNameForGetAll();

        protected virtual RepositoryContext<T> GetContext(String connectionString)
        {
            return new RepositoryContext<T>(connectionString);
        }

        public virtual IList<T> GetAll()
        {
            dynamic   requestResult = null;
            IList<T>  result = new List<T>();
            using (var context = GetContext(GetConnectionString()))
            {
                requestResult = context.Database?
                        .SqlQuery<T>(GetSpNameForGetAll())?
                        .ToList();                
            }
            foreach (var item in requestResult)
                result.Add((T)item);
            return result;
        }
    }
}
