using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Navigation;
using sf_sample.Commands;
using sf_sample.Helpers;
using sf_sample.Views;
using Xamarin.Forms;
using ListView = sf_sample.Views.ListView;

namespace sf_sample.ViewModels
{
    public class DashboardViewModel : BaseNavigableViewModel
    {
        private bool _executing;
        private ObservableCollection<CustomCommand> _menuItemCollection;

        public DashboardViewModel(INavigationService navigationService) : base(navigationService) { CreateCommands(); }

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
                new CustomCommand(NavigateToLinearChartViewMethod)
                {
                    Image = ImageSource.FromFile("chart.png"),
                    Text = "SfCartesianChart"
                },
                new CustomCommand(NavigateToPieChartViewMethod)
                {
                    Image = ImageSource.FromFile("chartpie.png"),
                    Text = "SfPieChart"
                },
                new CustomCommand(NavigateToBarChartViewMethod)
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
            await NavigationService.NavigateAsync(typeof(AutoCompleteView).GetNavigationId());
            await Task.Delay(200);
            _executing = false;
        }

        private async void NavigateToDataGridViewMethod()
        {
            if (_executing)
                return;
            _executing = true;
            await NavigationService.NavigateAsync(typeof(DataGridView).GetNavigationId());
            await Task.Delay(200);
            _executing = false;
        }

        private async void NavigateToLinearChartViewMethod()
        {
            if (_executing)
                return;
            _executing = true;
            await NavigationService.NavigateAsync(typeof(LinearChartView).GetNavigationId());
            await Task.Delay(200);
            _executing = false;
        }

        private async void NavigateToBarChartViewMethod()
        {
            if (_executing)
                return;
            _executing = true;
            await NavigationService.NavigateAsync(typeof(BarChartView).GetNavigationId());
            await Task.Delay(200);
            _executing = false;
        }

        private async void NavigateToPieChartViewMethod()
        {
            if (_executing)
                return;
            _executing = true;
            await NavigationService.NavigateAsync(typeof(PieChartView).GetNavigationId());
            await Task.Delay(200);
            _executing = false;
        }

        private async void NavigateToListViewMethod()
        {
            if (_executing)
                return;
            _executing = true;
            await NavigationService.NavigateAsync(typeof(ListView).GetNavigationId());
            await Task.Delay(200);
            _executing = false;
        }
    }
}