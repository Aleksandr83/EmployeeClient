// Copyright (c) 2021 Lukin Aleksandr
using alg.Data.Services.DB;
using alg.Services.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Data.Types
{
    public abstract class GenericDatabaseConfiguration : IDatabaseConfiguration
    {
        private const String DEFAULT_SERVER_NAME = "localhost";

        private String            _Name;
        private TDatabaseType     _DatabaseType;
        private IConnectionString _ConnectionString;

        public bool IsSavePassword { get; set; }

        public GenericDatabaseConfiguration(String configurationName)
        {
            _Name = configurationName.Trim();
        }

        public GenericDatabaseConfiguration
            (String configurationName, TDatabaseType databaseType) 
            : this(configurationName)
        {
            _DatabaseType = databaseType;
        }
            
        protected abstract String GetSettingsSectionName();
        protected abstract String GetServerSettingsParameterName();
        protected abstract String GetDatabaseSettingsParameterName();
        protected abstract String GetUserSettingsParameterName();
        protected abstract String GetPasswordSettingsParameterName();
        protected abstract String GetIsSavePasswordSettingsParameterName();
        protected abstract IDbService GetDbService();
        protected abstract ISettingsService GetSettingsService();

        public String GetName() => _Name;
        protected virtual  String GetDefaultServerName() => DEFAULT_SERVER_NAME;
        protected virtual  String GetDefaultUserName()   => String.Empty;
        public    virtual  bool   GetDefaultIsSavePassword() => true;
        public    virtual  TDatabaseType GetDatabaseType() => _DatabaseType;
        public    virtual  IConnectionString GetConnectionString() => _ConnectionString;

        public virtual void SetConnectionString(IConnectionString connectionString)
        {
            _ConnectionString = connectionString;
        }

        protected virtual IConnectionString CreateConnectionString
            (String server, String database, String login)
            => GetDbService()?.CreateConnectionString(server, database, login);

        public virtual IDatabaseConfiguration Load()
        {
            IConnectionString connectionString;
            var settingsService = GetSettingsService();
            var settingsSection = GetSettingsSectionName();
            var serverValue = settingsService?.GetStringValue
                (settingsSection, GetServerSettingsParameterName(), GetDefaultServerName());
            var databaseValue = settingsService?.GetStringValue
                (settingsSection, GetDatabaseSettingsParameterName());
            var userValue = settingsService?.GetStringValue
                (settingsSection, GetUserSettingsParameterName(), GetDefaultUserName());
            var passwordValue = settingsService?.GetStringValue
                (settingsSection, GetPasswordSettingsParameterName());
            connectionString = CreateConnectionString(serverValue, databaseValue, userValue);          
            IsSavePassword = settingsService?.GetBoolValue(settingsSection,
                GetIsSavePasswordSettingsParameterName()) ?? GetDefaultIsSavePassword();
            if (IsSavePassword)
                connectionString?.Password?.LoadEncodeString(passwordValue);
            SetConnectionString(connectionString);
            return this;

        }
        public virtual void Save()
        {
            IConnectionString connectionString;
            connectionString    = GetConnectionString();
            var settingsService = GetSettingsService();
            var settingsSection = GetSettingsSectionName();            
            settingsService?.SetStringValue
                (settingsSection, GetServerSettingsParameterName(), connectionString?.Server);
            settingsService?.SetStringValue
                (settingsSection, GetDatabaseSettingsParameterName(), connectionString?.Database);
            settingsService?.SetStringValue
                (settingsSection, GetUserSettingsParameterName(), connectionString?.Login);
            if (IsSavePassword)
            {
                settingsService?.SetStringValue
                    (
                        settingsSection, GetPasswordSettingsParameterName(),
                        connectionString?.Password?.GetEncodeString()
                    );
            }
            settingsService?.SetBoolValue
                (settingsSection, GetIsSavePasswordSettingsParameterName(), IsSavePassword);
            settingsService?.Save();
        }

    }
}
