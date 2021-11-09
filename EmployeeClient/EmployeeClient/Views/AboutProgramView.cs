// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Helpers;
using EmployeeClient.Services.App;
using EmployeeClient.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Views
{
    public partial class AboutProgramView : UserControl, IAboutProgramView
    {
        const string PREFIX_PROGRAM_INFO        = ": ";
        const string CMD_GET_PROGRAM_ID         = "ProgramID";
        const string CMD_GET_PROGRAM_NAME       = "ProgramName";
        const string CMD_GET_PROGRAM_VERSION    = "ProgramVersion";
        const string CMD_GET_PROGRAM_AUTHOR     = "ProgramAuthor";
        const string CMD_GET_PROGRAM_EMAIL      = "ProgramAuthorEmail";
        const string CMD_GET_PROGRAM_LICENSE    = "ProgramLicense";
        const string CMD_GET_PROGRAM_COPYRIGHT  = "ProgramCopyright";
        const string CMD_GET_PROGRAM_CONF_DIR   = "ProgramConfigurationDir";
        const string CMD_GET_PROGRAM_CONF_FILE  = "ProgramConfigurationFile";

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
        static readonly ResourceManager _ResourceManager = new ResourceManager(typeof(AboutProgramView));
        static ResourceManager GetResourceManager() => _ResourceManager;
        static String  GetResourceString(String name) => GetResourceManager().GetString(name);        
        #endregion ResourceManager

        public AboutProgramView()
        {
            InitializeComponent();
            UpdateControlsHeaders();
            UpdateControlsValues();
            SetToolTips();
        }

        private void UpdateControlsHeaders()
        {
            ResourcesManagerHelper.UpdateControlsHeaders
                (
                    this,
                    new Func<string, string>((x) => { return GetResourceString(x); }
                ));
        }

        private void UpdateControlsValues()
        {
            ResourcesManagerHelper.UpdateControlsValues
                (
                    this,
                    new Func<string, string>((x) => { return GetRequestInfoString(x); }
                ));
        }

        private void SetToolTips()
        {
            String toolTipText;
            toolTipText = GetResourceString("View.AboutProgram.ToolTips.CopyToClipboard");
            EmailCopyButtonToolTip.SetToolTip(CopyEmailButton, toolTipText);
            ConfigDirCopyButtonToolTip.SetToolTip(CopyConfigDirButton, toolTipText);
            ConfigFileCopyButtonToolTip.SetToolTip(CopyConfigFileButton, toolTipText);
            toolTipText = GetResourceString("View.AboutProgram.ToolTips.OpenFolderInExplorer");
            OpenConfigDirButtonToolTip.SetToolTip(OpenConfigFolderButton, toolTipText);
            toolTipText = GetResourceString("View.AboutProgram.ToolTips.OpenFileInNotepad");
            OpenConfigFileButtonToolTip.SetToolTip(OpenConfigFileButton, toolTipText);
        }

        private static IAppService GetAppService()
        {
            return (IAppService)ServicesManager.GetService<IAppService>();
        }

        private static String GetRequestInfoString(String cmd)
        {            
            ListDictionary actions = new ListDictionary();

            actions.Add(CMD_GET_PROGRAM_ID, new Func<String>(() => 
                { return string.Format
                    ("{0}{1}",PREFIX_PROGRAM_INFO,GetAppService().GetAppId());}));
            
            actions.Add(CMD_GET_PROGRAM_NAME, new Func<String>(() =>
                { return string.Format
                    ("{0}{1}", PREFIX_PROGRAM_INFO, GetAppService().GetAppName());}));
            
            actions.Add(CMD_GET_PROGRAM_VERSION, new Func<String>(() =>
                { return string.Format
                    ("{0}{1}", PREFIX_PROGRAM_INFO, GetAppService().GetAppVersion());}));
           
            actions.Add(CMD_GET_PROGRAM_AUTHOR, new Func<String>(() =>
                { return string.Format
                    ("{0}{1}", PREFIX_PROGRAM_INFO, GetAppService().GetAuthor());}));

            actions.Add(CMD_GET_PROGRAM_EMAIL, new Func<String>(() =>
            {
                return string.Format
                  ("{0}", GetAppService().GetAuthorEmail());
            }));
            
            actions.Add(CMD_GET_PROGRAM_LICENSE, new Func<String>(() =>
                { return string.Format
                    ("{0}{1}", PREFIX_PROGRAM_INFO, GetAppService().GetLicenseType());}));
            
            actions.Add(CMD_GET_PROGRAM_COPYRIGHT, new Func<String>(() =>
                { return string.Format
                    ("{0}{1}", PREFIX_PROGRAM_INFO, GetAppService().GetCopyright());}));
            
            actions.Add(CMD_GET_PROGRAM_CONF_DIR, new Func<String>(() =>
                { return GetAppService().GetConfigurationDataDir(); }));
            
            actions.Add(CMD_GET_PROGRAM_CONF_FILE, new Func<String>(() =>
                { return GetAppService().GetConfigurationFile(); }));

            if (actions.Contains(cmd))
                return (actions[cmd] as dynamic)?.Invoke();
            return null;
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion PropertyChanged

        private void CopyEmailButton_Click(object sender, EventArgs e)
        {
            var email = GetAppService().GetAuthorEmail();
            Clipboard.SetText(email);
        }

        private void OpenConfigFolderButton_Click(object sender, EventArgs e)
        {
            var folderPath = GetAppService().GetConfigurationDataDir();
            System.Diagnostics.Process.Start("explorer", folderPath);
        }

        private void CopyConfigDirButton_Click(object sender, EventArgs e)
        {
            var folderPath = GetAppService().GetConfigurationDataDir();
            Clipboard.SetText(folderPath);
        }

        private void CopyConfigFileButton_Click(object sender, EventArgs e)
        {
            var configFile = GetAppService().GetConfigurationFile();
            Clipboard.SetText(configFile);
        }

        private void OpenConfigFileButton_Click(object sender, EventArgs e)
        {
            var configFile = GetAppService().GetConfigurationFile();
            System.Diagnostics.Process.Start("notepad", configFile);
        }
    }
}
