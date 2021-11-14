// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.Reffers
{
    internal interface IReffersService : IService
    {
        void RefferRegistration(IReffer reffer);
        IReffer GetRefferByItemType(Type refferItemType);    
        
    }
}
