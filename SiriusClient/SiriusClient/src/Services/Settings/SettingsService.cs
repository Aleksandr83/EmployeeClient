// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Helpers;
using SiriusClient.Services.App;
using SiriusClient.Types.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient.Services.Settings
{
    internal class SettingsService:ISettingsService
    {
        public string GetStringValue
            (String section, String parameterName, String defaultValue)
        {
            String result;
            var configuration = GetConfiguration();
            result = configuration
                .GetSection(string.Format("{0}:{1}", section, parameterName))
                .Value;
            if (String.IsNullOrEmpty(result)) result = defaultValue;
            return result;
        }

        public void SetStringValue
            (String section, String parameterName,String value = "")
        {            
            var configuration = GetConfiguration();
            configuration
                .GetSection(string.Format("{0}:{1}",section, parameterName))
                .Value = value;
        }

        public bool GetBoolValue
            (String section, String parameterName, bool defaultValue = false)
        {
            bool result = defaultValue;           
            var configuration = GetConfiguration();
            var s = configuration
                .GetSection(string.Format("{0}:{1}", section, parameterName))
                .Value;
            bool.TryParse(s, out result);
            return result;
        }
        public void SetBoolValue
            (String section, String parameterName, bool value = false)
        {
            var configuration = GetConfiguration();
            configuration
                .GetSection(string.Format("{0}:{1}", section, parameterName))
                .Value = value.ToString()?.Normalize();
        }

        public void SetPasswordValue
            (String section, String parameterName, String password = "")
        {
            var configuration = GetConfiguration();
            configuration
                .GetSection(string.Format("{0}:{1}", section, parameterName))
                .Value = Base64Helper.Base64Encode(password);
        }
        
        private IConfiguration GetConfiguration()
        {
            return (IConfiguration)(ServicesManager
                .GetService<IAppService>() as IAppService)?
                .GetConfiguration();
        }

        public void Save()
        {           
            GetConfiguration().Save();
        }
    }
}