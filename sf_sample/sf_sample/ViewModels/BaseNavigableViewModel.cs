using Prism.Navigation;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    /// <summary>
    ///     BaseViewModel with navigation support
    /// </summary>
    public abstract class BaseNavigableViewModel : BaseViewModel, INavigationAware
    {
        public BaseNavigableViewModel() { CreateNavigateBackCommand(); }

        public INavigationService NavigationService { get; protected set; }
        public CustomCommand OpenConfigurationCommand { get; protected set; }
        public CustomCommand NavigateBackCommand { get; protected set; }

        protected void CreateNavigateBackCommand()
        {
            NavigateBackCommand = new CustomCommand(
                    async () =>
                    {
                        if (NavigationService == null)
                            return;
                        await NavigationService.GoBackAsync();
                    })
                {Image = ImageSource.FromFile("navBack.png")};
        }

        #region Implementation of INavigatedAware

        public void OnNavigatedFrom(NavigationParameters parameters) {  }

        public void OnNavigatedTo(NavigationParameters parameters) {  }

        #endregion

        #region Implementation of INavigatingAware

        public void OnNavigatingTo(NavigationParameters parameters) {  }

        #endregion
    }
}