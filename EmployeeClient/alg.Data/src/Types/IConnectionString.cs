// Copyright (c) 2021 Lukin Aleksandr
using alg.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Data.Types
{
    public interface IConnectionString
    {
        String    Server   { get; }
        String    Database { get; }
        String    Login    { get; }
        IPassword Password { get; }
                
        string ToMSSQL();
    }
}
