// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient.Repositories
{
    internal abstract class Repository
    {
        IList GetAll()
        {
            IList  result = null;

            return result;
        }
    }
}
