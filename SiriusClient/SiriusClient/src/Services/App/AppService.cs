// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient.Services.App
{
    internal class AppService : IAppService
    {
        private const String CONFIG_FILE_NAME = "config.json";
                
        public String GetAppId()
        {
            String appId = "";
            var attribute = (GuidAttribute)Assembly
                .GetEntryAssembly()?
                .GetCustomAttributes(typeof(GuidAttribute), true)[0];
            appId = attribute.Value;
            return appId;
        }

        public String GetAppName()
        {
            return Assembly.GetEntryAssembly()?.GetName()?.Name;
        }

        public String GetAppVersion()
        {
            return Assembly.GetEntryAssembly()?.GetName()?.Version?.ToString();
        }

        public String GetConfigurationDataDir()
        {
            String configurationDataDir;
            configurationDataDir = Path.Combine
                (
                   Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                   GetAppName()
                );
            return configurationDataDir;
        }        

        public bool IsExistConfigurationDataDir()
        {
            return Directory.Exists(GetConfigurationDataDir());
        }
        public void CreateConfigurationDataDir()
        {
            if (!IsExistConfigurationDataDir())
                Directory.CreateDirectory(GetConfigurationDataDir());
        }
        public String GetConfigurationFile()
        {
            String configFile;
            configFile = Path.Combine
                (
                   GetConfigurationDataDir(),
                   CONFIG_FILE_NAME
                );
            return configFile;
        }

        public bool IsExistConfigurationFile()
        {
            return File.Exists(GetConfigurationFile());
        }

        public void CreateConfigurationFile()
        {
            if (!IsExistConfigurationFile())
                File.Create(GetConfigurationFile());
        }
    }
}
