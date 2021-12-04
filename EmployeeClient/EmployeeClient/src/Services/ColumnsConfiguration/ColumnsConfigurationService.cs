﻿// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Helpers;
using EmployeeClient.Types.Controls.DataGrid.Schema;
using EmployeeClient.Types.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.ColumnsConfiguration
{
    internal class ColumnsConfigurationService : IColumnsConfigurationService
    {
        private const String RESOURCE_NAME = "zEmployeeListColumns.conf";
        private const String RESOURCE_PATH = "src.Configuration";

        private IList<ColumnsSchema> GetAllSchemas()
        {
            String jsonText = ResourcesManagerHelper
                .ReadStringResource(RESOURCE_NAME, RESOURCE_PATH);
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