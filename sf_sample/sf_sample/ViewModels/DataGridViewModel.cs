using Prism.Navigation;

namespace sf_sample.ViewModels
{
    public class DataGridViewModel : BaseNavigableViewModel
    {
        public DataGridViewModel(INavigationService navigationService) { NavigationService = navigationService; }

        private void CreateCommands() { }
    }
}