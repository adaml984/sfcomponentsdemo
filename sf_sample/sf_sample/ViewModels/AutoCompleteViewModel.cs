using Prism.Navigation;

namespace sf_sample.ViewModels
{
    public class AutoCompleteViewModel : BaseNavigableViewModel
    {
        public AutoCompleteViewModel(INavigationService navigationService) { NavigationService = navigationService; }

        private void CreateCommands() { }
    }
}