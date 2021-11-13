// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Data.Types;
using EmployeeClient.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.DB
{
    internal class DbService : IDbService
    {
        public IDatabaseConfiguration PrimaryDbConfiguration { get; }

        public DbService()
        {
            PrimaryDbConfiguration = (IDatabaseConfiguration)new MsSqlDatabaseConfiguration();
        }

        protected virtual IPassword CreatePassword() => new Password();
        public IConnectionString CreateConnectionString(String server, String database, String login)
        {
            return new ConnectionString(server, database, login, CreatePassword());
        }       
       
    }
}
