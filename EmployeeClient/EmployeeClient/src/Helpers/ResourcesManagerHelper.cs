// Copyright (c) 2021 Lukin Aleksandr
using alg.Types.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Helpers
{
    internal sealed class ResourcesManagerHelper<T> where T : class
    {
        const String RESOURCE_PREFIX_HEADERS = "%%";
        const String RESOURCE_PREFIX_VALUES  = "%!";

        private static object LK = new object();
        private static ResourcesControlInitializator<T> Resources { get; set; } = null;

        private static String GetFullResourceName
            (String resourceName, String resourcePath, Assembly assembly)
        {
            if (String.IsNullOrEmpty(resourcePath))
                return $"{assembly.GetName().Name}.{resourceName.Replace('\\', '.')}";
            else
                return $"{assembly.GetName().Name}.{resourcePath}.{resourceName.Replace('\\', '.')}";
        }

        public static bool IsExistResource
            (String resourceName,String resourcePath = "",Assembly assembly = null)
        {            
            if (assembly == null)
                assembly = Assembly.GetExecutingAssembly();
            String fullResourceName = GetFullResourceName(resourceName, resourcePath, assembly);
            return assembly?
                .GetManifestResourceNames()
                .Contains(fullResourceName) ?? false;
        }

        public static bool IsExistResource(String fullResourceName,Assembly assembly = null)
        {
            if (assembly == null)
                assembly = Assembly.GetExecutingAssembly();
            return assembly?
                .GetManifestResourceNames()
                .Contains(fullResourceName) ?? false;
        }

        public static String GetResourceString(String resourceName)
        {
            lock (LK)
            {
                if (Resources == null)
                    Resources = new ResourcesControlInitializator<T>();
            }
            return Resources.GetResourceString(resourceName);
        }

        public static String GetStringResource
            (String resourceName, String resourcePath, Assembly assembly = null)
        {            
            if (assembly == null)
                assembly = Assembly.GetExecutingAssembly();
            String fullResourceName = GetFullResourceName(resourceName, resourcePath, assembly);
            if (!IsExistResource(fullResourceName, assembly))
                return String.Empty;
            using (Stream resourceStream = assembly?.GetManifestResourceStream(fullResourceName))
            using (StreamReader sr = new StreamReader(resourceStream))
            {
               sr.BaseStream.Seek(0, SeekOrigin.Begin);
               return sr.ReadToEnd();                
            }            
        }

        public static void UpdateControlsHeaders(IUserControl view)            
        {
            lock(LK)
            {
                if (Resources == null)
                    Resources = new ResourcesControlInitializator<T>();
            }            
            UpdateControlsHeaders(view, new Func<string, string>((x) =>
            { 
                return Resources.GetResourceString(x); 
            }));

        }

        public static void UpdateControlsHeaders
            (
                IUserControl view,
                Func<String, String> resourceReaderMethod,
                TControlFieldProperty fieldProperty = TControlFieldProperty.Text
            )
        {
            new Task(new Action(() => {
                UpdateControls
                    (
                        view, 
                        resourceReaderMethod, 
                        RESOURCE_PREFIX_HEADERS, 
                        fieldProperty
                    );
            })).Start();
        }

        
        public static void UpdateControlsValues
            (
                IUserControl view,
                Func<String, String> resourceReaderMethod,
                TControlFieldProperty fieldProperty = TControlFieldProperty.Text
            )
        {
            new Task(new Action(() => { 
                UpdateControls
                    (
                        view,
                        resourceReaderMethod,
                        RESOURCE_PREFIX_VALUES,
                        fieldProperty
                    );
            })).Start();
        }

        private static void UpdateControls
            (
                IUserControl view, 
                Func<String,String> resourceReaderMethod,
                String prefix,
                TControlFieldProperty fieldProperty = TControlFieldProperty.Text
            )
        {
            string s;
            var stack = new Stack<Control>();
            var rootControls = (view as UserControl)?.Controls;
            if (rootControls == null) 
                return;
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
                if (childrens == null) 
                    continue;
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
                if (!control.InvokeRequired)
                     control.Text = value;
                else
                    control?.Invoke(new Action<Control, String>((x, y) 
                        => { x.Text = y; }),control, value);
                return;
            }
        }

    }
}
