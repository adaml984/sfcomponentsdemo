using Prism.Navigation;
using sf_sample.Commands;
using sf_sample.Views.Popups;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class AutoCompleteViewModel : BaseNavigableViewModel
    {
        public AutoCompleteViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            CreateCommands();
        }

        private void CreateCommands()
        {
            OpenConfigurationCommand = new CustomCommand(
                    async () => { await NavigationService.PushPopupPageAsync(AutoCompleteConfigPopupView.NavigationId); })
                {Image = ImageSource.FromFile("settings.png")};
        }
    }
}