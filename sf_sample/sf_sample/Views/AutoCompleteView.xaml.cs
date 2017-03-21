using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sf_sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutoCompleteView : ContentPage
    {
        public const string NavigationId = "AutoCompleteView";

        public AutoCompleteView() { InitializeComponent(); }
    }
}