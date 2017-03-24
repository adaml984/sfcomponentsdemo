using Prism.Navigation;
using sf_sample.Commands;
using sf_sample.Helpers;
using sf_sample.Views.Popups;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class AutoCompleteViewModel : BaseNavigableViewModel
    {
        public AutoCompleteViewModel(INavigationService navigationService) : base(navigationService)
        {
            CreateCommands();
        }

        private void CreateCommands()
        {
            OpenConfigurationCommand = new CustomCommand(
                    async () =>
                    {
                        await NavigationService.PushPopupPageAsync(typeof(AutoCompleteConfigPopupView).GetNavigationId());
                    })
                {Image = ImageSource.FromFile("settings.png")};
        }
    }
}