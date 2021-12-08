// Copyright (c) 2021 Lukin Aleksandr
using alg.Types;
using EmployeeClient.Data.Models.Reffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.Reffers
{
    internal sealed class Reffers
    {
        public static void Registration()
        {
            var reffersService = (IReffersService)ServicesManager
                .GetService<IReffersService>();
            reffersService.RefferRegistration(ReffersFactory.Create<Post>());
            reffersService.RefferRegistration(ReffersFactory.Create<Status>());
            reffersService.RefferRegistration(ReffersFactory.Create<Departament>());
        }
    }
}
