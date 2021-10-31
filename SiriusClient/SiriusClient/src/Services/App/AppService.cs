// Copyright (c) 2021 Lukin Aleksandr
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        IConfigurationRoot _Configuration;

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

        public String GetAuthor()
        {
            return "Lukin Aleksandr";
        }

        public String GetAuthorEmail()
        {
            return "lukin.a.g.spb@gmail.com";
        }

        public String GetLicenseType()
        {
            return "GPL-3.0 License";
        }

        public String GetCopyright()
        {
            var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            return versionInfo.LegalCopyright;
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

        public String GetConfigurationFileName() => CONFIG_FILE_NAME;

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
            {                
                var jsonObj  = new SettingsClass();
                var jsonText = JsonConvert.SerializeObject(jsonObj, Formatting.None);
                File.WriteAllText(GetConfigurationFile(), jsonText);
            }
        }

        public void InitConfiguration()
        {
            CreateConfigurationDataDir();
            CreateConfigurationFile();
            _Configuration = (IConfigurationRoot)new ConfigurationBuilder()?
                .SetBasePath(GetConfigurationDataDir())?               
                .Add<WritableJsonConfigurationSource>
                    (
                        (Action<WritableJsonConfigurationSource>)( s => 
                        {
                            s.FileProvider   = null;
                            s.Path           = GetConfigurationFileName();
                            s.Optional       = false;
                            s.ReloadOnChange = true;
                            s.ResolveFileProvider();
                        })
                    )
                .Build();
        }

        public dynamic GetConfiguration() => _Configuration;

        private class WritableJsonConfigurationSource : JsonConfigurationSource
        {
            public override IConfigurationProvider Build(IConfigurationBuilder builder)
            {
                this.EnsureDefaults(builder);
                return (IConfigurationProvider)new WritableJsonConfigurationProvider(this);
            }
        }

        private class WritableJsonConfigurationProvider : JsonConfigurationProvider
        {
            public WritableJsonConfigurationProvider(JsonConfigurationSource source)
                : base(source)
            {
            }

            public override void Set(string key, string value)
            {
                base.Set(key, value);
                
                var fileFullPath = base.Source.FileProvider.GetFileInfo(base.Source.Path).PhysicalPath;
                String json = File.ReadAllText(fileFullPath);
                var sectionName   = key.Split(':')?.First()?.Trim();
                var parameterName = key.Split(':')?.Last()?.Trim();
                var settings = JsonConvert.DeserializeObject<SettingsClass>(json);
                SectionBlock section = settings.GetSectionByName(sectionName);
                if (section == null)                
                    section = settings.Add(new SectionBlock() { Section = sectionName });
                section.SetValue(parameterName, value);                
                string output = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText(fileFullPath, output);
            }

        }

        private class SettingsClass
        {
            public List<SectionBlock> Settings { get; set; } = new List<SectionBlock>();

            public SectionBlock GetSectionByName(String sectionName)
            {                 
                foreach (var section in Settings)
                {
                    if (section.Section == sectionName)                    
                        return section;                   
                }
                return null;
            }

            public SectionBlock Add(SectionBlock section)
            { 
                Settings.Add(section);
                return section;
            }
        }

        private class SectionBlock
        {
            public string Section { get; set; }           

            public List<SectionValue> Values { get; private set; }
                    = new List<SectionValue>();

            public void SetValue(String key, String value)
            {                
                foreach(var item in Values)
                {
                    if (item.GetKey() == key)
                    {
                        item.SetValue(value);
                        return;
                    }
                }                
                Values.Add(new SectionValue(key, value));
            }
        }

        private class SectionValue
        {           
            public String[] Value = new String[2]{ "", "" };
    
            public SectionValue()
            {
            }

            public SectionValue(String key,String value)
            {
                SetKey(key);
                SetValue(value);
            }

            public String GetKey() => Value.First();
            public void SetKey(String key)
            {
                Value[0] = key;
            }

            public String GetValue() => Value.Last();
            public void SetValue(String value)
            {
                Value[1] = value;
            }

        }
    }
}
