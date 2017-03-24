using Prism.Navigation;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class BarChartViewModel : BaseNavigableViewModel
    {
        public BarChartViewModel(INavigationService navigationService) : base(navigationService) { CreateCommands(); }

        private void CreateCommands()
        {
            OpenConfigurationCommand = new CustomCommand(
                    async () => { })
                {Image = ImageSource.FromFile("settings.png")};
        }
    }
}