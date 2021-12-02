// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Types.Controls.DataGrid.Schema
{
    public class ColumnsSchema
    {
        public String Name { get; set; }
        public IList<Column> Columns { get; set; } = new List<Column>();      
    }
}
