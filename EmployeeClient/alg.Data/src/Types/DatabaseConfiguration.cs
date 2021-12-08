// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alg.Data.Services.DB;
using alg.Services.Settings;
using alg.Types;

namespace alg.Data.Types
{
    public abstract class DatabaseConfiguration 
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
