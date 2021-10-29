// Copyright (c) 2021 Lukin Aleksandr
using SiriusClient.Services.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiriusClient.Helpers
{
    internal sealed class ResourcesManagerHelper
    {
        const String RESOURCE_PREFIX = "%%";
        public static void UpdateControlsHeaders(IView view, Func<String,String> resourceReaderMethod)
        {
            string s;
            var stack = new Stack<Control>();
            var rootControls = (view as UserControl)?.Controls;
            foreach (var control in rootControls)
                stack?.Push((Control)control);
            while (stack?.Count > 0)
            {
                var control = stack.Pop();
                s = control?.Text?.Trim();
                if ((!String.IsNullOrEmpty(s))&&(s.StartsWith(RESOURCE_PREFIX)))
                {
                    s = s.Substring(RESOURCE_PREFIX.Length)?.Trim();
                    s = resourceReaderMethod.Invoke(s);
                    control.Text = s;
                }
                var childrens = control?.Controls;
                foreach (var child in childrens)                
                    stack?.Push((Control)child);               
            }
        }
    }
}
