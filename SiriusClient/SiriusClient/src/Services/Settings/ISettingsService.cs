// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient.Services.Settings
{
    internal interface ISettingsService:IService
    {
        string GetStringValue(String section, String parameterName,String defaultValue = "");
        void   SetStringValue(String section, String parameterName,String value = "");       
        void   SetPasswordValue(String section, String parameterName,String password = "");
    }
}
