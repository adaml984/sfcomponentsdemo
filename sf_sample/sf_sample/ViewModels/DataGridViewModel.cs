using System;
using System.Collections.ObjectModel;
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

        private void Init() { CreateTestData(); }

        //private Task<ObservableCollection<DataGridItem>> CreateTestData()
        private void CreateTestData()
        {
            //return Task.Factory.StartNew(
            //(() =>
            //{
            var thisMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            Items = new ObservableCollection<DataGridItem>();
            for (var i = 0; i < 10; i++)
            {
                Items.Add(new DataGridItem() {Id = i, FirstName = "A", LastName = "B"});
                thisMonth = thisMonth.AddDays(1);
            }
            //return tmpCollection;
            // }));
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