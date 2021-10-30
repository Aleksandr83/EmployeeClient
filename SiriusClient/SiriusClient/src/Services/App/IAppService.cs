// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient.Services.App
{
    internal interface IAppService : IService
    {
        String GetAppId();
        String GetAppName();
        String GetAppVersion();
        String GetConfigurationDataDir();        
        bool   IsExistConfigurationDataDir();
        void   CreateConfigurationDataDir();
        String GetConfigurationFile();
        bool   IsExistConfigurationFile();
        void   CreateConfigurationFile();
    }
}
