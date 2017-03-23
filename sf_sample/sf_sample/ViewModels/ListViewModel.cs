using System.Collections.ObjectModel;
using Prism.Navigation;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class ListViewModel : BaseNavigableViewModel
    {
        private ObservableCollection<ListItem> _items;

        public ListViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            CreateCommands();
        }

        public ObservableCollection<ListItem> Items { get { return _items; } set { SetProperty(ref _items, value); } }

        public CustomCommand EditItemCommand { get; set; }

        public CustomCommand DeleteItemCommand { get; set; }

        private void CreateCommands()
        {
            EditItemCommand = new CustomCommand(
                    () => { })
                {Image = ImageSource.FromFile("pencil.png")};

            DeleteItemCommand = new CustomCommand(
                    () => { })
                {Image = ImageSource.FromFile("delete.png")};
        }
    }
}