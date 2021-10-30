// Copyright (c) 2021 Lukin Aleksandr
using Microsoft.Extensions.Configuration;
using SiriusClient.Services.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient.Services.Settings
{
    internal class SettingsService:ISettingsService
    {
        public string GetStringValue(String section, String parameterName, String defaultValue)
        {
            String result = defaultValue;
            return result;
        }

        public void SetStringValue(String section, String parameterName,String value = "")
        {
            var appService = (IAppService)ServicesManager
                .GetService<IAppService>();
            var configuration = (IConfigurationRoot)appService.GetConfiguration();
            configuration.GetSection(string.Format("{0}:{1}",section,parameterName)).Value = value;
        }       

        public void SetPasswordValue(String section, String parameterName, String password = "")
        {

        }
    }
}
