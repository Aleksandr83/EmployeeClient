// Copyright (c) 2021 Lukin Aleksandr
using alg.Data.Services.DB;
using alg.Data.Types;
using alg.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Data.Repositories
{
    public abstract class Repository<T>:
        GenericRepository<T> where T : class
    {
        protected override String GetConnectionString()
        {
            var dbService = GetDbService();
            IConnectionString connectionString = null;
            var configuration = dbService?.PrimaryDbConfiguration;
            if (dbService?.PrimaryDbConfiguration?.GetDatabaseType() == TDatabaseType.MSSQL)
            {
                connectionString = configuration?.GetConnectionString();
                if (configuration?.GetDatabaseType() == TDatabaseType.MSSQL)
                    return connectionString.ToMSSQL();
            }
            return "";
        }

        protected IDbService GetDbService()
        {
            return (IDbService)ServicesManager.GetService<IDbService>();
        }
    }
}
