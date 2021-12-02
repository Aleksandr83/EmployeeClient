// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Types.Controls.DataGrid.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.ColumnsConfiguration
{
    internal interface IColumnsConfigurationService : IService
    {           
        ColumnsSchema GetColumnsSchemaByName(String schemaName);
    }
}
