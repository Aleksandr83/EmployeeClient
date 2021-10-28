// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient.Services.Views
{
    internal interface IView
    {
        void Hide();
        void Show();
        void Update();
    }
}
