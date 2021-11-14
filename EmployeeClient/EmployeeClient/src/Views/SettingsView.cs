// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Configuration;
using EmployeeClient.Helpers;
using EmployeeClient.Services.Commands;
using EmployeeClient.Services.DB;
using EmployeeClient.Services.Settings;
using EmployeeClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace EmployeeClient.Views
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
            SetToolTips();
            Update(); 
        }

        private ISettingsService GetSettingsService()
        {
            return (ISettingsService)ServicesManager
                .GetService<ISettingsService>();
        }

        private IDbService GetDbService()
        {
            return (IDbService)ServicesManager
                .GetService<IDbService>();
        }

        private ICommandsService GetCommandsService()
        {
            return (ICommandsService)ServicesManager
                .GetService<ICommandsService>();
        }

        public new void Update()
        {
            base.Update();
            LoadFormFields();
            OnClick(new EventArgs());
        }

        void LoadFormFields()
        {
            var configuration    = GetDbService()?.PrimaryDbConfiguration?.Load();           
            var connectionString = configuration?.GetConnectionString();             
            SetFieldServerName(connectionString?.Server);
            SetFieldDatabase(connectionString?.Database);
            SetFieldLogin(connectionString?.Login);
            SetFieldPassword(String.Empty);
            if (GetDbService()?.PrimaryDbConfiguration?.IsSavePassword??false)
                SetFieldPassword(connectionString?.Password?.GetValue());       
            SetFieldIsSavePassword(configuration?.IsSavePassword??configuration.GetDefaultIsSavePassword());         
        }

        void SaveFormFields()
        {
            var configuration = GetDbService()?.PrimaryDbConfiguration;
            if (configuration == null) return;
            var connectionString = GetDbService()?.CreateConnectionString
                (
                    GetFieldServerName(),
                    GetFieldDatabase(),
                    GetFieldLogin()
                );
            connectionString?.Password?.SetValue(GetFieldPassword());            
            configuration.IsSavePassword = GetFieldIsSavePassword();
            configuration.SetConnectionString(connectionString);           
        }

        void ResetPassword()
        {            
            var configuration = GetDbService()?.PrimaryDbConfiguration;          
            var connectionString = configuration?.GetConnectionString();
            connectionString?.Password.SetValue(String.Empty);
            SetFieldPassword(null);
            configuration?.Save();
        }        

        private void SetToolTips()
        {
            String toolTipText;
            toolTipText = GetResourceString("View.Settings.DB.ResetPasswordButton");
            this.ResetPassButtonToolTip.SetToolTip(ResetPasswordButton, toolTipText);
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

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.ActiveControl = this.ConnectionButton;
        }

        private void ConnectionButton_Click(object sender, EventArgs e)
        {
            SaveFormFields();
            GetCommandsService()?
                .GetCommandByName(CommandsNames.CONNECTED_TO_DB)?
                .Execute(null);
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            ResetPassword();          
        }
    }
}
