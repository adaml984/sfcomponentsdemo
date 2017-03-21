using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Navigation;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class DashboardViewModel : BaseNavigableViewModel
    {
        private ObservableCollection<CustomCommand> _menuItemCollection;

        public DashboardViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            CreateCommands();
        }

        public ObservableCollection<CustomCommand> MenuItemCollection
        {
            get { return _menuItemCollection; }
            set { SetProperty(ref _menuItemCollection, value); }
        }

        private void CreateCommands()
        {
            MenuItemCollection = new ObservableCollection<CustomCommand>
            {
                new CustomCommand(NavigateToDataGridViewMethod)
                {
                    Image = ImageSource.FromFile("grid.png"),
                    Text="SfDataGrid"
                },
                new CustomCommand(NavigateToChartViewMethod)
                {
                    Image = ImageSource.FromFile("chart.png"),
                    Text="SfChart"
                },
                new CustomCommand(NavigateToAutoCompleteViewMethod)
                {
                    Image = ImageSource.FromFile("textbox.png"),
                    Text="SfAutoComplete"
                }
            };
        }

        private async Task NavigateToAutoCompleteViewMethod()
        {
            await NavigationService.NavigateAsync(Views.AutoCompleteView.NavigationId);
        }

        private async Task NavigateToDataGridViewMethod() { await NavigationService.NavigateAsync(Views.DataGridView.NavigationId); }

        private async Task NavigateToChartViewMethod()
        {
            await NavigationService.NavigateAsync(Views.ChartView.NavigationId);
        }
    }
}