using Prism.Navigation;

namespace sf_sample.ViewModels
{
    /// <summary>
    ///     BaseViewModel with navigation support
    /// </summary>
    public abstract class BaseNavigableViewModel : BaseViewModel
    {
        public INavigationService NavigationService { get; set; }
    }
}