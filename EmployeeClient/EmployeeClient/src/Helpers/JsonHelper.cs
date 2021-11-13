// Copyright (c) 2021 Lukin Aleksandr
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Helpers
{
    internal class JsonHelper
    {
        public static String Serialize(object value)
        {
            if (value == null)
                return String.Empty;
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }

        public static T Deserialize<T>(String json) where T : class
        {
            return (T)JsonConvert.DeserializeObject<T>(json);
        }
    }
}
