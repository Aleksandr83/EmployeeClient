// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Types
{
    public interface IDatabaseConfiguration
    {
        bool IsSavePassword { get; set; }
        TDatabaseType     GetDatabaseType();
        IConnectionString GetConnectionString();
        bool GetDefaultIsSavePassword();
        void SetConnectionString(IConnectionString connectionString);
        IDatabaseConfiguration Load();
        void Save();

    }
}
