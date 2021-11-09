// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Services.Views
{
    public interface IView
    {
        String Header { get; }
        void Hide();
        void Show();
        void Update();        
        
    }
}
