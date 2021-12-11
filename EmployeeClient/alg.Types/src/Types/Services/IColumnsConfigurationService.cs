// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls.DataGrid.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Services
{
    public interface IColumnsConfigurationService : IService
    {           
        ColumnsSchema GetColumnsSchemaByName(String schemaName);
    }
}
