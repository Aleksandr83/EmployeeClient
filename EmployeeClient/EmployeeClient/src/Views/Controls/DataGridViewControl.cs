// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Types.Controls.DataGrid;
using EmployeeClient.Types.Controls.DataGrid.Schema;
using EmployeeClient.Types.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Controls
{
    public partial class DataGridViewControl : UserControl, IDataGridControl
    {
        ColumnsSchema _ColumnsSchema;

        public DataGridViewControl()
        {
            InitializeComponent();        
        }

        private DataGridView  GetDataGridView()  => this.dataGridView1;
        private ColumnsSchema GetColumnsSchema() => _ColumnsSchema;

        public void SetColumnsSchema(ColumnsSchema columnsSchema)
        {
            _ColumnsSchema = columnsSchema;
        }

        public void CreateColumns()
        {
            ClearColumns();
            var columnsSchema = GetColumnsSchema();
            foreach (var columnSchema in columnsSchema?.Columns??List.Empty<Column>())
            {
                AddColumn(columnSchema);
            }
        }

        private void ClearColumns()
        {
            GetDataGridView()?.Columns?.Clear();
        }

        private void AddColumn(Column columnSchema)
        {
            var column = new DataGridViewTextBoxColumn()
            {
                HeaderText = columnSchema.Header,
                Width      = columnSchema.DefaultWidth
            };
            GetDataGridView()?.Columns?.Add(column);
        }
    }
}
