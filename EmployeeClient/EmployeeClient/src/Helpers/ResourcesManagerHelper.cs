// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Services.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Helpers
{
    internal sealed class ResourcesManagerHelper
    {
        const String RESOURCE_PREFIX_HEADERS = "%%";
        const String RESOURCE_PREFIX_VALUES  = "%!";

        public enum TControlFieldProperty
        {
            Text
        }

        public static void UpdateControlsHeaders
            (
                IView view,
                Func<String, String> resourceReaderMethod,
                TControlFieldProperty fieldProperty = TControlFieldProperty.Text
            )
        {
            UpdateControls
                (
                    view, 
                    resourceReaderMethod, 
                    RESOURCE_PREFIX_HEADERS, 
                    fieldProperty
                );
        }

        public static void UpdateControlsValues
            (
                IView view,
                Func<String, String> resourceReaderMethod,
                TControlFieldProperty fieldProperty = TControlFieldProperty.Text
            )
        {
            UpdateControls
                (
                    view,
                    resourceReaderMethod,
                    RESOURCE_PREFIX_VALUES,
                    fieldProperty
                );
        }

        private static void UpdateControls
            (
                IView view, 
                Func<String,String> resourceReaderMethod,
                String prefix,
                TControlFieldProperty fieldProperty = TControlFieldProperty.Text
            )
        {
            string s;
            var stack = new Stack<Control>();
            var rootControls = (view as UserControl)?.Controls;
            foreach (var control in rootControls)
                stack?.Push((Control)control);
            while (stack?.Count > 0)
            {
                var control = stack.Pop();               
                s = GetControlFieldValue(control, fieldProperty);
                if ((!String.IsNullOrEmpty(s))&&(s.StartsWith(prefix)))
                {
                    s = s.Substring(prefix.Length)?.Trim();
                    s = resourceReaderMethod.Invoke(s);                    
                    SetControlFieldValue(control,s,fieldProperty);
                }
                var childrens = control?.Controls;
                foreach (var child in childrens)                
                    stack?.Push((Control)child);               
            }
        }

        private static String GetControlFieldValue
            (
                Control control, 
                TControlFieldProperty fieldProperty
            )
        {
            if (fieldProperty == TControlFieldProperty.Text)
                return control?.Text?.Trim();
            return null;
        }

        private static void SetControlFieldValue
            (
                Control control,
                String  value,
                TControlFieldProperty fieldProperty
            )
        {
            if (fieldProperty == TControlFieldProperty.Text)
            {
                control.Text = value;
                return;
            }
        }

    }
}
