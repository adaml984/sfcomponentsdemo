using Xamarin.Forms.Xaml;

namespace sf_sample.Views.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutoCompleteConfigPopup
    {
        public const string NavigationId = "AutocompleteConfigPopup";

        public AutoCompleteConfigPopup()
        {
            InitializeComponent();
        }
    }
}