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
        bool   GetBoolValue(String section, String parameterName, bool defaultValue = false);
        void   SetBoolValue(String section, String parameterName, bool value = false);
        void   SetPasswordValue(String section, String parameterName,String password = "");
        void   Save();
    }
}
