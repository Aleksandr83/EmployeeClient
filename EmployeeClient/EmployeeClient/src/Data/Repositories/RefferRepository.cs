// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Repositories
{
    internal class RefferRepository<T> : 
        GenericRepository<T> where T : class, IReffer
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

        protected override String GetConnectionString()
        {
            if (GetRepositoryType() == TRefferRepositoryType.SinglePrimaryDatabase)
            {

            }
            return "";
        }

    }
}
