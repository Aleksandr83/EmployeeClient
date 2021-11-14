// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Configuration;
using EmployeeClient.Data.Models.Reffers;
using EmployeeClient.Helpers;
using EmployeeClient.Services.Reffers;
using EmployeeClient.Types.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Controls
{
    public partial class EmployeeListFiltersControl : UserControl, IUserControl
    {       
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
            ResourcesManagerHelper.UpdateControlsHeaders
                (this, new Func<string, string>((x) => { return GetResourceString(x); }));
            Init();
            Update(); // temp
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
                    source?.Add((T)item);
            }
        }
        private void LoadItemsInFilter<T>(IList<T> source) 
            where T : class
        {         
            var reffersService = (IReffersService)ServicesManager
                .GetService<IReffersService>();
            var reffer = reffersService?.GetRefferByItemType(typeof(T));
            var items  = reffer?.GetRefferItems();
            InsertItemsInFilter<T>(source, items);
        }

        private void LoadFilters() 
        {
            LoadItemsInFilter<Post>(Posts);
            LoadItemsInFilter<Status>(Statuses);
            LoadItemsInFilter<Departament>(Departaments);
        }
       
    }
}
