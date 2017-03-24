using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Navigation;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class DataGridViewModel : BaseNavigableViewModel
    {
        private ObservableCollection<DataGridItem> _items;

        public DataGridViewModel(INavigationService navigationService) : base(navigationService)
        {
            CreateCommands();
            Init();
        }

        public ObservableCollection<DataGridItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public CustomCommand EditItemCommand { get; set; }

        public CustomCommand DeleteItemCommand { get; set; }

        private async void Init() { Items = await CreateTestData(); }

        private Task<ObservableCollection<DataGridItem>> CreateTestData()
        {
            return Task.Factory.StartNew(
                () =>
                {
                    var thisMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    var tmpCollection = new ObservableCollection<DataGridItem>();
                    for (var i = 0; i < 10; i++)
                    {
                        tmpCollection.Add(new DataGridItem() {Id = i, FirstName = "A", LastName = "B"});
                        thisMonth = thisMonth.AddDays(1);
                    }
                    return tmpCollection;
                });
        }

        private void CreateCommands()
        {
            EditItemCommand = new CustomCommand(
                () => { }) {Image = ImageSource.FromFile("pencil.png")};

            DeleteItemCommand = new CustomCommand(
                () => { }) {Image = ImageSource.FromFile("delete.png")};
        }
    }
}