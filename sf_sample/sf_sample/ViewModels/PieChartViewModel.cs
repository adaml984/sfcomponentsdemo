using Prism.Navigation;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class PieChartViewModel : BaseNavigableViewModel
    {
        public PieChartViewModel(INavigationService navigationService) : base(navigationService) { CreateCommands(); }

        private void CreateCommands()
        {
            OpenConfigurationCommand = new CustomCommand(
                    async () => { })
                {Image = ImageSource.FromFile("settings.png")};
        }
    }
}