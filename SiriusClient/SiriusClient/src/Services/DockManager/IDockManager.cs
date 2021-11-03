using SiriusClient.Services.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriusClient.Services.DockManager
{
    internal interface IDockManager
    {
        IView GetActiveView();
        void  AddView(IView view);
        
    }
}
