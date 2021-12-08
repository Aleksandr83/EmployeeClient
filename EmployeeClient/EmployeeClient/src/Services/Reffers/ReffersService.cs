// Copyright (c) 2021 Lukin Aleksandr
using alg.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.Reffers
{
    internal class ReffersService : IReffersService
    {
        public void RefferRegistration(IReffer reffer)
        {
            ReffersManager.Registration(reffer);
        }
        public IReffer GetRefferByItemType(Type refferItemType)
        {
            return ReffersManager.GetRefferByItemType(refferItemType);
        }        
    }
}
