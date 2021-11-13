// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Data.Types;
using EmployeeClient.Services;
using EmployeeClient.Services.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Repositories
{
    internal class RefferRepository<T> : 
        GenericRepository<T>,IReffer where T : class
    {
        private String                _RepositoryName;
        private TRefferRepositoryType _RepositoryType;
 
        public RefferRepository
            (
                String repositoryName, 
                TRefferRepositoryType repositoryType = TRefferRepositoryType.SinglePrimaryDatabase
            )
        {
            _RepositoryName = repositoryName;
            _RepositoryType = repositoryType;
        }

        private TRefferRepositoryType GetRepositoryType() => _RepositoryType;

        private IDbService GetDbService()
        {
            return (IDbService)ServicesManager.GetService<IDbService>();
        }

        protected override String GetConnectionString()
        {
            var dbService = GetDbService();
            IConnectionString connectionString = null; 
            if (GetRepositoryType() == TRefferRepositoryType.SinglePrimaryDatabase)
            {
                //connectionString = dbService?.GetPrimaryConnectionString();
                //if (dbService?.GetPrimaryDatabaseType() == TDatabaseType.MSSQL)
                //    return connectionString.ToMSSQL();
            }
            return "";
        }

        public String Test()
        {       
            return GetConnectionString();
        }

    }
}
