// Copyright (c) 2021 Lukin Aleksandr
using alg.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alg.Data.Repositories
{
    internal class DataFiltersCollection<TKey>
    {      
        private MultiValuesDictionary<TKey, DataFilterValue> Items { get; set; }

        public DataFiltersCollection()
        {
            Items = new MultiValuesDictionary<TKey, DataFilterValue>();
        }

        public void SetValue(TKey key, dynamic value)
        {
            if (Items.IsContainsKey(key))
            {
                Items?.GetValues(key)
                    .FirstOrDefault()?
                    .SetValue(value);
            }
        }

        public dynamic GetValue(TKey key)
        {
            if (Items.IsContainsKey(key))
            {
                return Items?.GetValues(key)
                    .FirstOrDefault();
            }
            return null;        
        }

        public void Add(TKey key, dynamic value)
        {
            Items?.Add(key, new DataFilterValue(value));
        }

        public void Clear()
        {
            Items?.Clear();
        }
    }
}
