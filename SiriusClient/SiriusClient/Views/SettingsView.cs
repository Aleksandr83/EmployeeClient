// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Configuration;
using SiriusClient.Helpers;
using SiriusClient.Services.Settings;
using SiriusClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiriusClient.Views
{
    public partial class SettingsView : UserControl, ISettingsView
    {
        #region Header
        String _Header = GetResourceString("View.Header");

        public String Header
        {
            get { return _Header; }
            private set
            {
                _Header = value;
                OnPropertyChanged("Header");
            }
        }
        #endregion Header

        #region ResourceManager
        static readonly ResourceManager _ResourceManager = new ResourceManager(typeof(SettingsView));
        static ResourceManager GetResourceManager() => _ResourceManager;
        static String GetResourceString(String name) => GetResourceManager()?.GetString(name);
        #endregion ResourceManager

        public SettingsView()
        {
            InitializeComponent();
            ResourcesManagerHelper.UpdateControlsHeaders(this, new Func<string, string>((x) => { return GetResourceString(x); }));
            LoadFormFieldsOnStartup();
        }

        void LoadFormFieldsOnStartup()
        {
            String s;
            String parameterName;
            String settingsSection;            
            var settingsService = (ISettingsService)ServicesManager
                .GetService<ISettingsService>();
            settingsSection = SettingsSections.SETTINGS_SECTION_DB;
            parameterName   = SettingsNames.SETTINGS_DB_SERVER;
            s = settingsService.GetStringValue(settingsSection, parameterName, "localhost");
            SetFieldServerName(s);
            parameterName   = SettingsNames.SETTINGS_DB_DATABASE; 
            s = settingsService.GetStringValue(settingsSection, parameterName);
            SetFieldDatabase(s);
            parameterName   = SettingsNames.SETTINGS_DB_LOGIN;
            s = settingsService.GetStringValue(settingsSection, parameterName, "sa");
            SetFieldLogin(s);


            parameterName   = SettingsNames.SETTINGS_DB_PASSWORD;
            s = settingsService.GetStringValue(settingsSection, parameterName);
            SetFieldPassword(s);
        }

        void SaveFormFields()
        {         
            String parameterName;
            String settingsSection;
            var settingsService = (ISettingsService)ServicesManager
                .GetService<ISettingsService>();
            settingsSection = SettingsSections.SETTINGS_SECTION_DB;
            parameterName = SettingsNames.SETTINGS_DB_SERVER;           
            settingsService.SetStringValue(settingsSection, parameterName, GetFieldServerName());
            parameterName = SettingsNames.SETTINGS_DB_DATABASE;        
            settingsService.SetStringValue(settingsSection, parameterName, GetFieldDatabase());
            parameterName = SettingsNames.SETTINGS_DB_LOGIN;      
            settingsService.SetStringValue(settingsSection, parameterName, GetFieldLogin());
            parameterName = SettingsNames.SETTINGS_DB_PASSWORD;
            settingsService.SetPasswordValue(settingsSection, parameterName, GetFieldPassword());
        }

        void ResetPassword()
        {
            String parameterName;
            String settingsSection;
            var settingsService = (ISettingsService)ServicesManager
                .GetService<ISettingsService>();
            settingsSection = SettingsSections.SETTINGS_SECTION_DB;
            parameterName = SettingsNames.SETTINGS_DB_PASSWORD;
            settingsService.SetPasswordValue(settingsSection, parameterName);
        }

        String GetFieldServerName() => Field_ServerName.Text;
        void SetFieldServerName(String serverName)
        {
            Field_ServerName.Text = serverName;
        }

        String GetFieldDatabase() => Field_Database.Text;
        void SetFieldDatabase(String database)
        {
            Field_Database.Text = database;
        }

        String GetFieldLogin() => Field_Login.Text;
        void SetFieldLogin(String login)
        {
            Field_Login.Text = login;
        }

        String GetFieldPassword() => Field_Password.Text;
        void SetFieldPassword(String password)
        {
            Field_Password.Text = password;
        }
              
        bool GetFieldIsSavePassword() => Field_IsSavePassword.Checked;
        void SetFieldIsSavePassword(bool value)
        {
            Field_IsSavePassword.Checked = value;
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion PropertyChanged

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            SaveFormFields();
            // connect to database

        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            ResetPassword();
        }
    }
}
