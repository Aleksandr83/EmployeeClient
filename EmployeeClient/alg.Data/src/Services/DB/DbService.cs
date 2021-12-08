// Copyright (c) 2021 Lukin Aleksandr
using alg.Data.Types;
using alg.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Data.Services.DB
{
    public abstract class DbService : IDbService
    {
        public IDatabaseConfiguration PrimaryDbConfiguration { get; }

        public DbService()
        {
            //PrimaryDbConfiguration = (IDatabaseConfiguration)new MsSqlDatabaseConfiguration();
            PrimaryDbConfiguration = CreatePrimaryDbConfiguration();
        }

        protected virtual IPassword CreatePassword() => new Password();
        protected abstract IDatabaseConfiguration CreatePrimaryDbConfiguration();        
        public IConnectionString CreateConnectionString(String server, String database, String login)
        {
            return new ConnectionString(server, database, login, CreatePassword());
        }       
       
    }
}
