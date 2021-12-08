// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls.DataGrid.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Types.Controls.DataGrid
{
    public interface IDataGridControl
    {
        void CreateColumns();
        void SetColumnsSchema(ColumnsSchema columnsSchema);
        void SetDataSource(object dataSource);
        void SetAutoGenerateColumns(bool value);
        void SetReadOnly(bool value);
        void SetAllowUserAddRows(bool value);
    }
}
