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

        public String GetRepositoryName() => _RepositoryName;
        public Type   GetRefferItemType() => typeof(T);
        private TRefferRepositoryType GetRepositoryType() => _RepositoryType;

        private IDbService GetDbService()
        {
            return (IDbService)ServicesManager.GetService<IDbService>();
        }

        protected override String GetSpNameForGetAll()
        {
            return String.Format("uspGet{0}Reffer", GetRepositoryName());
        }

        protected override String GetConnectionString()
        {
            var dbService = GetDbService();           
            IConnectionString connectionString = null; 
            if (GetRepositoryType() == TRefferRepositoryType.SinglePrimaryDatabase)
            {
                var configuration = dbService?.PrimaryDbConfiguration;
                connectionString  = configuration?.GetConnectionString();
                if (configuration?.GetDatabaseType() == TDatabaseType.MSSQL)
                    return connectionString.ToMSSQL();
            }
            return "";
        }

        public virtual IList<dynamic> GetRefferItems()
        {
             return new List<dynamic>(GetAll());
        }

    }
}
