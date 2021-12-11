// Copyright (c) 2021 Lukin Aleksandr
using alg.Services;
using alg.Types.Controls.DataGrid.Schema;
using alg.Types.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace alg.Types.Controls.DataGrid
{
    public sealed class DataGridInitializator<T>  
        : ResourcesControlInitializator<T> where T : class
    {
        private IDataGridControl _DataGridControl;
        private String           _ColumnSchemaName;
        private object           _DataGridSource;
        private ColumnsSchema    _ColumnsSchema;

        public DataGridInitializator
            (IDataGridControl dataGrid,dynamic source,String columnsSchemaName)
        {
            SetDataGridControl(dataGrid);
            SetDataGridSource(source);
            SetColumnsSchemaName(columnsSchemaName);
        }

        public DataGridInitializator<T> Init()
        {
            InitDataGrid();
            return this;
        }

        #region DataGrid
        private String GetColumnsSchemaName()
            => _ColumnSchemaName;
        private String SetColumnsSchemaName(String value)
            => _ColumnSchemaName = value;
        private dynamic GetDataGridSource() 
            => _DataGridSource;
        private dynamic SetDataGridSource(object source)
            => _DataGridSource = source;
        private IDataGridControl GetDataGridControl() 
            => _DataGridControl;
        private IDataGridControl SetDataGridControl(IDataGridControl control) 
            => _DataGridControl = control;

        private void InitDataGrid()
        {
            InitColumnsSchema();
            var dataGrid = GetDataGridControl();
            dataGrid?.SetReadOnly(true);
            dataGrid?.SetAutoGenerateColumns(false);
            dataGrid?.SetAllowUserAddRows(false);
            dataGrid?.SetColumnsSchema(GetColumnsSchema());
            dataGrid?.CreateColumns();
            dataGrid?.SetDataSource(GetDataGridSource());
        }

        private void InitColumnsSchema()
        {
            var columnsConfigurationService = GetColumnsConfigurationService();
            var columnsSchema = SetColumnsSchema(columnsConfigurationService?
                .GetColumnsSchemaByName(GetColumnsSchemaName()));
            var columns = columnsSchema?.Columns;
            foreach (var column in columns ?? List.Empty<Column>())
            {
                if (column == null) continue;
                column.Header = GetColumnNameByHeaderId(column.HeaderId);
            }
        }

        private String GetColumnNameByHeaderId(String headerId)
        {
            return GetResourceString(headerId);           
        }

        private ColumnsSchema GetColumnsSchema() => _ColumnsSchema;

        private ColumnsSchema SetColumnsSchema(ColumnsSchema columnsSchema)
        {
            return _ColumnsSchema = columnsSchema;
        }

        private IColumnsConfigurationService GetColumnsConfigurationService() =>
            (IColumnsConfigurationService)ServicesManager
                .GetService<IColumnsConfigurationService>();
        
        #endregion DataGrid
       
    }
}
