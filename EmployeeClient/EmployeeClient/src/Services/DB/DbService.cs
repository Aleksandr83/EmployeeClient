// Copyright (c) 2021 Lukin Aleksandr
using alg.Data.Types;
using alg.Types;
using EmployeeClient.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.src.Services.DB
{
    internal class DbService:
        alg.Data.Services.DB.DbService
    {
        protected override IDatabaseConfiguration CreatePrimaryDbConfiguration()
        {
            return (IDatabaseConfiguration)new MsSqlDatabaseConfiguration();
        }
     
    }
}
