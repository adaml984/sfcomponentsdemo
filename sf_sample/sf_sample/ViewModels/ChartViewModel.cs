using Prism.Navigation;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class ChartViewModel : BaseNavigableViewModel
    {
        public ChartViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            CreateCommands();
        }

        private void CreateCommands()
        {
            OpenConfigurationCommand = new CustomCommand(
                    () => { })
                {Image = ImageSource.FromFile("settings.png")};
        }
    }
}