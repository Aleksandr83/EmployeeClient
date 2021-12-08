// Copyright (c) 2021 Lukin Aleksandr
using alg.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Types
{
    internal class MsSqlDatabaseConfiguration : DatabaseConfiguration
    {
        public MsSqlDatabaseConfiguration(String configurationName = "")
            : base(configurationName,TDatabaseType.MSSQL)
        {
        }

    }
}
