using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Navigation;
using sf_sample.Commands;
using sf_sample.Helpers;
using sf_sample.ViewModels.Data;
using sf_sample.Views.Popups;
using Xamarin.Forms;

namespace sf_sample.ViewModels
{
    public class AutoCompleteViewModel : BaseNavigableViewModel
    {
        private ObservableCollection<AutoCompleteItem> _items;
        public AutoCompleteViewModel(INavigationService navigationService) : base(navigationService)
        {
            CreateCommands();
        }

        public ObservableCollection<AutoCompleteItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }
        private async void Init() { Items = await CreateTestData(); }

        private Task<ObservableCollection<AutoCompleteItem>> CreateTestData()
        {
            return Task.Factory.StartNew(
                () =>
                {
                    var thisMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    var tmpCollection = new ObservableCollection<AutoCompleteItem>();
                    for (var i = 0; i < 100; i++)
                    {
                        tmpCollection.Add(new AutoCompleteItem() { City="aAAA" });
                        thisMonth = thisMonth.AddDays(1);
                    }
                    return tmpCollection;
                });
        }
        private void CreateCommands()
        {
            OpenConfigurationCommand = new CustomCommand(
                    async () =>
                    {
                        await NavigationService.PushPopupPageAsync(typeof(AutoCompleteConfigPopupView).GetNavigationId());
                    })
                {Image = ImageSource.FromFile("settings.png")};
        }
    }
}