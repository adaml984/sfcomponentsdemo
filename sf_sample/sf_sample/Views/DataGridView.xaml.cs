using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sf_sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataGridView : ContentPage
    {
        public const string NavigationId = "DataGridView";
        public DataGridView()
        {
            InitializeComponent();
        }
    }
}
