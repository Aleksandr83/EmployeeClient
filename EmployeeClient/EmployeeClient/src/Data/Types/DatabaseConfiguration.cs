// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Configuration;
using EmployeeClient.Services.DB;
using EmployeeClient.Services.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Types
{
    internal abstract class DatabaseConfiguration 
        : GenericDatabaseConfiguration
    {

        public DatabaseConfiguration(String configurationName)
            :base(configurationName)
        {            
        }

        public DatabaseConfiguration
            (String configurationName,TDatabaseType databaseType)
            :base(configurationName,databaseType)
        {            
        }
        
        protected override String GetServerSettingsParameterName() 
            => SettingsNames.SETTINGS_DB_SERVER;
        protected override String GetDatabaseSettingsParameterName()
            => SettingsNames.SETTINGS_DB_DATABASE;
        protected override String GetUserSettingsParameterName()
            => SettingsNames.SETTINGS_DB_LOGIN;
        protected override String GetPasswordSettingsParameterName()
            => SettingsNames.SETTINGS_DB_PASSWORD;
        protected override String GetIsSavePasswordSettingsParameterName()
            => SettingsNames.SETTINGS_DB_ISSAVEPASSWORD;        

        protected override String GetSettingsSectionName()
        {
            String sectionPostfixFormat;
            sectionPostfixFormat = String.IsNullOrEmpty(GetName()) ? "{0}" : ".{0}";
            return String.Concat
                (
                    SettingsSections.SETTINGS_SECTION_DB,
                    String.Format(sectionPostfixFormat, GetName()??String.Empty)
                );
        }
        protected override ISettingsService GetSettingsService()
        {
            return (ISettingsService)ServicesManager
                .GetService<ISettingsService>();
        }

        protected override IDbService GetDbService()
        {
            return (IDbService)ServicesManager
                .GetService<IDbService>();
        }
    }
}
