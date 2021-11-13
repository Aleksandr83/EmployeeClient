// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Types
{
    internal interface IPasswordContainer
    {
        String GetPassword();
        void   SetPassword(String password);
        String ToJson();
    }
}
