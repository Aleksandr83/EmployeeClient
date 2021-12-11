// Copyright (c) 2021 Lukin Aleksandr
using alg.Services.Settings;
using alg.Types;
using alg.Types.Controls;
using EmployeeClient.Configuration;
using EmployeeClient.Data.Models.Reffers;
using EmployeeClient.Helpers;
using EmployeeClient.Services.Reffers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Controls
{
    public partial class EmployeeListFiltersControl : UserControl, IUserControl
    {
        private int DEFAULT_TIMEOUT = 10000;
        private int MIN_TIMEOUT     = 1000;

        BindingList<Post>        Posts        = new BindingList<Post>();
        BindingList<Status>      Statuses     = new BindingList<Status>();
        BindingList<Departament> Departaments = new BindingList<Departament>();

        bool IsInsertEmptyFilter { get; set; } = true;

        #region ResourceManager
        static readonly ResourceManager _ResourceManager = new ResourceManager(typeof(EmployeeListFiltersControl));
        static ResourceManager GetResourceManager() => _ResourceManager;
        static String GetResourceString(String name) => GetResourceManager()?.GetString(name);
        #endregion ResourceManager

        public EmployeeListFiltersControl()
        {
            InitializeComponent();
            ResourcesManagerHelper<EmployeeListFiltersControl>
                .UpdateControlsHeaders(this);            
            Init();            
        }
                
        private void Init()
        {
            Field_Post.DataSource           = Posts;
            Field_Post.DisplayMember        = "Name";
            Field_Status.DataSource         = Statuses;
            Field_Status.DisplayMember      = "Name";
            Field_Departament.DataSource    = Departaments;
            Field_Departament.DisplayMember = "Name";
        }

        public new void Update()
        {
            base.Update();
            LoadFilters(); 
        }

        private dynamic CreateEmptyFilterItem<T>() 
            where T : class
        {            
            var item  = (RefferModel)Activator.CreateInstance(typeof(T));
            item.Id   = ReffersFiltres.FILTER_EMPTY_ID;
            item.Name = ReffersFiltres.FILTER_EMPTY_NAME;
            return item;
        }
        private void InsertItemsInFilter<T>(IList<T> source,IList<dynamic> items) 
            where T : class
        {
            source?.Clear();
            if (IsInsertEmptyFilter)
                source?.Add((T)CreateEmptyFilterItem<T>());
            if (items != null)
            {
                foreach (var item in items)
                    if (!InvokeRequired)
                        source?.Add((T)item);
                    else
                    {
                        Invoke(new Action<IList<T>,T>((x,y) 
                            => { x.Add(y); }), source, item);
                    }
            }
        }
        private void LoadItemsInFilter<T>(IList<T> source) 
            where T : class
        {
            try
            {
                var reffersService = (IReffersService)ServicesManager
                    .GetService<IReffersService>();
                var reffer = reffersService?.GetRefferByItemType(typeof(T));
                var items = reffer?.GetRefferItems();
                InsertItemsInFilter<T>(source, items);
            }
            catch (Exception) { }
        }

        private void LoadFilters() 
        {
            var task = new Task<int>(new Func<int>(() => 
            {
                var settingsService = GetSettingsService();
                int timeout = settingsService.GetIntValue
                    (
                        SettingsSections.SETTINGS_SECTION_DB,
                        SettingsNames.SETTINGS_DB_TIMEOUT,
                        DEFAULT_TIMEOUT
                    );
                if (timeout < MIN_TIMEOUT) timeout = MIN_TIMEOUT;

                Thread th = new Thread(() => 
                {
                    lock (this)
                    {
                        LoadItemsInFilter<Post>(Posts);
                        LoadItemsInFilter<Status>(Statuses);
                        LoadItemsInFilter<Departament>(Departaments);                       
                    }
                });

                th.Start();                
                th.Join(DEFAULT_TIMEOUT);
                th.Abort();                
                return 0; 
            }));
            task.Start();             
        }
        private ISettingsService GetSettingsService()
        {
            return (ISettingsService)ServicesManager
                .GetService<ISettingsService>();
        }

    }
}
