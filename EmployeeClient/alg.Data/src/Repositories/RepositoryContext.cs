// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Data.Repositories
{
    public class RepositoryContext<T> : DbContext where T : class
    {

        public RepositoryContext()
            :base()
        {
            Init();
        }

        public RepositoryContext(String connectionString)
            : base(connectionString) 
        {
            Init();
        }

        protected virtual void Init()
        {
            Database.SetInitializer<RepositoryContext<T>>(null);
        }
    }
}
