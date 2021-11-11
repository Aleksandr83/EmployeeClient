// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.DB
{
    internal class DbService : IDbService
    {
        public IConnectionString GetPrimaryConnectionString()
        {
            return DbManager.GetPrimaryConnectionString();
        }

        public void SetPrimaryConnectionString(IConnectionString connectionString)
        {
            DbManager.SetPrimaryConnectionString(connectionString);
        }
    }
}
