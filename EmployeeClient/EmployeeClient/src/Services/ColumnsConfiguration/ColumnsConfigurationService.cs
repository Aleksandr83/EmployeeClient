// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Helpers;
using alg.Services;
using alg.Types.Controls.DataGrid.Schema;
using alg.Types.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using alg.Helpers;

namespace EmployeeClient.Services.ColumnsConfiguration
{
    internal class ColumnsConfigurationService : IColumnsConfigurationService
    {
        private const String RESOURCE_NAME = "ColumnsConfiguration.conf";
        private const String RESOURCE_PATH = "src.Configuration.DataGridView";

        private IList<ColumnsSchema> GetAllSchemas()
        {
            String jsonText = ResourcesManagerHelper<object>
                .GetStringResource(RESOURCE_NAME, RESOURCE_PATH);
            return JsonHelper
                .Deserialize<JsonCollection<ColumnsSchema>>(jsonText)?.Items;
        }

        public ColumnsSchema GetColumnsSchemaByName(String schemaName)
        {
            return GetAllSchemas()?
                .Where(x => x.Name == schemaName).FirstOrDefault();
        }
    }
}
