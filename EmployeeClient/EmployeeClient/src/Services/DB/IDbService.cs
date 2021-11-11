// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.DB
{
    internal interface IDbService : IService
    {        
        IConnectionString GetPrimaryConnectionString();
        void SetPrimaryConnectionString(IConnectionString connectionString);
    }
}
