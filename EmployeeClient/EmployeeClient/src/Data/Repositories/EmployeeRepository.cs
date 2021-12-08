// Copyright (c) 2021 Lukin Aleksandr
using alg.Data.Repositories;
using EmployeeClient.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Repositories
{
    internal class EmployeeRepository
        : Repository<Employee>
    {

        protected override string GetSpNameForGetAll()
        {
            return "uspGetPersons";
        }

    }
}
