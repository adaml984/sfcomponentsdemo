using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Navigation;
using sf_sample.Commands;
using sf_sample.Views;
using Xamarin.Forms;
using ListView = sf_sample.Views.ListView;

namespace sf_sample.ViewModels
{
    public class DashboardViewModel : BaseNavigableViewModel
    {
        private bool _executing;
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
                    Text = "SfDataGrid"
                },
                new CustomCommand(NavigateToListViewMethod)
                {
                    Image = ImageSource.FromFile("list.png"),
                    Text = "SfListView"
                },
                new CustomCommand(NavigateToAutoCompleteViewMethod)
                {
                    Image = ImageSource.FromFile("textbox.png"),
                    Text = "SfAutoComplete"
                },
                new CustomCommand(NavigateToChartViewMethod)
                {
                    Image = ImageSource.FromFile("chart.png"),
                    Text = "SfCartesianChart"
                },
                new CustomCommand(NavigateToChartViewMethod)
                {
                    Image = ImageSource.FromFile("chartpie.png"),
                    Text = "SfPieChart"
                },
                new CustomCommand(NavigateToChartViewMethod)
                {
                    Image = ImageSource.FromFile("chartbar.png"),
                    Text = "SfBarChart"
                }
            };
        }

        private async void NavigateToAutoCompleteViewMethod()
        {
            if (_executing)
                return;
            _executing = true;
            await NavigationService.NavigateAsync(AutoCompleteView.NavigationId);
            await Task.Delay(200);
            _executing = false;
        }

        private async void NavigateToDataGridViewMethod()
        {
            if (_executing)
                return;
            _executing = true;
            await NavigationService.NavigateAsync(DataGridView.NavigationId);
            await Task.Delay(200);
            _executing = false;
        }

        private async void NavigateToChartViewMethod()
        {
            if (_executing)
                return;
            _executing = true;
            await NavigationService.NavigateAsync(ChartView.NavigationId);
            await Task.Delay(200);
            _executing = false;
        }

        private async void NavigateToListViewMethod()
        {
            if (_executing)
                return;
            _executing = true;
            await NavigationService.NavigateAsync(ListView.NavigationId);
            await Task.Delay(200);
            _executing = false;
        }
    }
}