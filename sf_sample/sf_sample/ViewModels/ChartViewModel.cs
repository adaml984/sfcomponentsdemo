using Prism.Navigation;

namespace sf_sample.ViewModels
{
    public class ChartViewModel : BaseNavigableViewModel
    {
        public ChartViewModel(INavigationService navigationService) { NavigationService = navigationService; }

        private void CreateCommands() { }
    }
}