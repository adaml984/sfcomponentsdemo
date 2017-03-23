using Syncfusion.Data;
using Syncfusion.SfDataGrid.XForms;
using Xamarin.Forms;

namespace sf_sample.Views
{
    public partial class DataGridView : ContentPage
    {
        public const string NavigationId = "DataGridView";

        public DataGridView()
        {
            InitializeComponent();
            var dg = new SfDataGrid();

        }
    }
}