// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace alg.Types.Controls
{
    public class DataFilter<T> 
        : DataBindBroker<T> 
    {
        #region Header
        private String _Header = "";
        public String Header
        {
            get { return _Header; }
            set
            {
                _Header = value;
                OnPropertyChanged("Header");
            }
        }
        #endregion Header
        
        public String FilterName { get; set; }

        public DataFilter()
        {
        }               

        public Type GetValueType()
            => typeof(T);        

    }
}
