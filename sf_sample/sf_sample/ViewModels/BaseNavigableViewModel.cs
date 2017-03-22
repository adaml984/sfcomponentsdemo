using Prism.Navigation;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    /// <summary>
    ///     BaseViewModel with navigation support
    /// </summary>
    public abstract class BaseNavigableViewModel : BaseViewModel
    {
        public BaseNavigableViewModel()
        {
            CreateNavigateBackCommand();
        }
        public INavigationService NavigationService { get; protected set; }
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
    }
}