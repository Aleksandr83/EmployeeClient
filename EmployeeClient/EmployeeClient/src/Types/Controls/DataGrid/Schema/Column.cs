// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Types.Controls.DataGrid.Schema
{
    public class Column
    {
        public string Header   { get; set; }
        public string HeaderId { get; set; }
        public string Name     { get; set; }
        public string Width    { get; set; }
        public int    DefaultWidth    { get; set; }
    }
}
