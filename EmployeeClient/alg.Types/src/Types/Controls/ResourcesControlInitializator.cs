// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace alg.Types.Controls
{
    public class ResourcesControlInitializator<T> where T : class 
    {
        private readonly ResourceManager _ResourceManager = new ResourceManager(typeof(T));
                
        private ResourceManager GetResourceManager() 
            => _ResourceManager;
        public String GetResourceString(String name) 
            => GetResourceManager().GetString(name);
    }
}
