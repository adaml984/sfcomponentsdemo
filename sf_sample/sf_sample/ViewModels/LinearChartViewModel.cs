using Prism.Navigation;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class LinearChartViewModel : BaseNavigableViewModel
    {
        public LinearChartViewModel(INavigationService navigationService) : base(navigationService) { CreateCommands(); }

        private void CreateCommands()
        {
            OpenConfigurationCommand = new CustomCommand(
                    () => { })
                {Image = ImageSource.FromFile("settings.png")};
        }
    }
}