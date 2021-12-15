// Copyright (c) 2021 Lukin Aleksandr
using EmployeeClient.Helpers;
using EmployeeClient.Types;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Controls
{
    public partial class PaginatorControl 
        : UserControl, INotifyPropertyChanged
    {
        private uint _CurrentPage = 0;
        private uint _CountPages  = 0;

        private BindingList<ushort>  _Items ;
        private DataBindBroker<String> PageInfoText { get; set; }

        #region CurrentPage
        public uint CurrentPage
        {
            get { return _CurrentPage; }
            set 
            { 
                SetCurrentPage(value);
                OnPropertyChanged("CurrentPage");
            }
        }
        #endregion CurrentPage

        #region CountPages
        public uint CountPages
        {
            get { return _CountPages; }
            set
            {
                SetCountPages(value);
                OnPropertyChanged("CountPages");
            }
        }
        #endregion CountPages

        public PaginatorControl()
        {            
            InitializeComponent();
            Init();
        }       

        private void Init()
        {
            _Items        = new BindingList<ushort>() { 100, 150, 200 };
            PageInfoText  = new DataBindBroker<string>();
            PageInfoText
                .Bind(GetPageInfoControl(), "Text");

            GetCountRecordsFilterControl()
                .DataSource = GetItems();

            UpdateLabelRecordsCount();

            CurrentPage = 1;
        }

        public uint GetCurrentPage() 
            => _CurrentPage;

        private void SetCurrentPage(uint value)
        {
            _CurrentPage = value;
            UpdatePageInfoText();
        }


        public uint GetCountPages() 
            => _CountPages;

        private void SetCountPages(uint value)
        {
            _CountPages = value;
            UpdatePageInfoText();
        }

        private void UpdateLabelRecordsCount()
            => GetRecordsCountLabelControl()
            .Text = ResourcesManagerHelper<PaginatorControl>
                .GetResourceString("Paginator.Label.RecordsOnPage");

        private void UpdatePageInfoText()
        {
            if (GetCurrentPage() == 0)
            {
                PageInfoText.Value = String.Empty;
                return;
            }

            String pageText = ResourcesManagerHelper<PaginatorControl>
                .GetResourceString("Paginator.Label.Page");
            String pageFrom = ResourcesManagerHelper<PaginatorControl>
                .GetResourceString("Paginator.Label.From");

            var countPages = GetCountPages();
            if  (countPages == 0) CountPages = 1;

            PageInfoText
                .Value = $"{pageText} {GetCurrentPage()} {pageFrom} {GetCountPages()}";
        }

        private IList GetItems() 
            => _Items;

        private Control GetPageInfoControl() 
            => PageInfo;

        private void InitCountRecordsFilter()
        {
            var comboBox = GetCountRecordsFilterControl();
            comboBox.DataSource = GetItems();
        }

        private ComboBox GetCountRecordsFilterControl()
            => CountRecordsFilterComboBox;

        private Label GetRecordsCountLabelControl()
            => RecordsCount;

        public void SetRightOffsetLabelRecordsCount(int value)
            => GetRecordsCountLabelControl().Left += value;

        public void SetRightOffsetComboBox(int value)
            => GetCountRecordsFilterControl().Left += value;

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion PropertyChanged

    }
}
