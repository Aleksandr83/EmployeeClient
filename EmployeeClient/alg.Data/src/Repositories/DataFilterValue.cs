// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Data.Repositories
{
    internal class DataFilterValue
    {
        private dynamic _Value;

        public DataFilterValue()
        {
        }

        public DataFilterValue(dynamic value)
        {
            SetValue(value);
        }

        public dynamic GetValue() => _Value;
        public dynamic SetValue(dynamic value)
        {
            return _Value = value;
        }
             
        public override string ToString()
        {
            var value = GetValue();
            return (value is String)? value : value.ToString();
        }

    }
}
