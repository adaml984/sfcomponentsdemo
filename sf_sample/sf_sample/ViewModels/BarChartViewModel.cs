using System.Collections.ObjectModel;
using Prism.Navigation;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class BarChartViewModel : BaseNavigableViewModel
    {
        private ObservableCollection<BarChartData> _data;

        public BarChartViewModel(INavigationService navigationService) : base(navigationService)
        {
            Data = new ObservableCollection<BarChartData>()
            {
                new BarChartData {Name = "David", Height = 180},
                new BarChartData {Name = "Michael", Height = 170},
                new BarChartData {Name = "Steve", Height = 160},
                new BarChartData {Name = "Joel", Height = 182},
            };
            CreateCommands();
        }

        public ObservableCollection<BarChartData> Data { get { return _data; } set { SetProperty(ref _data, value); } }

        private void CreateCommands()
        {
            OpenConfigurationCommand = new CustomCommand(
                    async () => { })
                {Image = ImageSource.FromFile("settings.png")};
        }
    }
}