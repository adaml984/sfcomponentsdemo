﻿using Prism.Unity;
using sf_sample.Views;

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
            Container.RegisterTypeForNavigation<DashboardView>(DashboardView.NavigationId);
            Container.RegisterTypeForNavigation<DataGridView>(DataGridView.NavigationId);
            Container.RegisterTypeForNavigation<AutoCompleteView>(AutoCompleteView.NavigationId);
            Container.RegisterTypeForNavigation<ChartView>(ChartView.NavigationId);
        }

        #endregion
    }
}