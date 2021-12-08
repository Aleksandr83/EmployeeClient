// Copyright (c) 2021 Lukin Aleksandr
using alg.Services;
using alg.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services
{
    internal sealed class ReffersManager : GenericManager
    {
        public static IReffer GetRefferByItemType(Type refferItemType)
        {
            return GetAll<IReffer>()?
                .Where(x => x.GetRefferItemType() == refferItemType)?
                .FirstOrDefault();            
        }
    }
}
