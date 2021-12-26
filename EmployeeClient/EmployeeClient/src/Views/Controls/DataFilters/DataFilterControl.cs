using EmployeeClient.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClient.Controls.DataFiltres
{  
    public partial class DataFilterControl 
        : UserControl, 
        alg.Types.Controls.IFilterControl<String>,        
        INotifyPropertyChanged
    {

        [Browsable(true), Bindable(true), ]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]        
        [DisplayName(@"Text"), Category("Appearance"), DefaultValue("")]      
        public  override String Text
        {
            get { return Filter.Header;  }
            set { Filter.Header = value; }
        }

        private DataFilter<String> Filter { get; set; }

        public DataFilterControl()
        {
            InitializeComponent();
            Filter = new DataFilter<string>();
            Filter.BindingHeader(LabelHeader, "Text");
            //Filter.BindingValue
           
        }

        public string GetFilterName()
            => Filter.FilterName;

        public String GetValue()
            => Filter.Value;

        public Type GetValueType()
            =>Filter.GetValueType();


        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion PropertyChanged
    }
}
