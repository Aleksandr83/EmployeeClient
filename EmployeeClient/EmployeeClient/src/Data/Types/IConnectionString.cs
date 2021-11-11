// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Types
{
    internal interface IConnectionString
    {
        String Server           { get; }
        String Database         { get; }
        String Login            { get; }
        String Password         { get; }
        bool IsPasswordDecode   { get; }

        string ToMSSQL();
    }
}
