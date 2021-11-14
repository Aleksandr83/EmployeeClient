// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Repositories
{
    internal abstract class Repository<T>:
        GenericRepository<T> where T : class
    {
        protected override String GetConnectionString()
        {
            return "";
        }
    }
}
