using Microsoft.Practices.Unity;
using Prism.Unity;
using sf_sample.Helpers;
using sf_sample.ViewModels;
using sf_sample.Views;
using sf_sample.Views.Popups;

namespace sf_sample
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();
            MainPage = new DashboardView();
        }

        #region Overrides of PrismApplicationBase<IUnityContainer>

        protected override void OnInitialized() { }

        protected override void RegisterTypes()
        {
            RegisterInstances();
            RegisterTypesForNavigation();
        }

        private void RegisterInstances()
        {
            Container.RegisterInstance(new AutoCompleteConfigPopupViewModel(NavigationService));
        }

        private void RegisterTypesForNavigation()
        {
            Container.RegisterTypeForNavigation<DashboardView>(typeof(DashboardView).GetNavigationId());
            Container.RegisterTypeForNavigation<DataGridView>(typeof(DataGridView).GetNavigationId());
            Container.RegisterTypeForNavigation<AutoCompleteView>(typeof(AutoCompleteView).GetNavigationId());
            Container.RegisterTypeForNavigation<ChartView>(typeof(LinearChartView).GetNavigationId());
            Container.RegisterTypeForNavigation<ChartView>(typeof(PieChartView).GetNavigationId());
            Container.RegisterTypeForNavigation<ChartView>(typeof(BarChartView).GetNavigationId());
            Container.RegisterTypeForNavigation<ListView>(typeof(ListView).GetNavigationId());
            Container.RegisterTypeForNavigation<AutoCompleteConfigPopupView>(
                typeof(AutoCompleteConfigPopupView).GetNavigationId());
        }

        #endregion
    }
}