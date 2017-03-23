using Prism.Navigation;

namespace sf_sample.ViewModels
{
    public class AutoCompleteConfigPopupViewModel : BaseNavigableViewModel
    {
        public AutoCompleteConfigPopupViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}