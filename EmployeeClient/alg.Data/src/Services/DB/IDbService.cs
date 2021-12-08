// Copyright (c) 2021 Lukin Aleksandr
using alg.Data.Types;
using alg.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Data.Services.DB
{
    public interface IDbService : IService
    {
        IDatabaseConfiguration PrimaryDbConfiguration { get; }
        IConnectionString CreateConnectionString(String server, String database, String login);

    }
}
