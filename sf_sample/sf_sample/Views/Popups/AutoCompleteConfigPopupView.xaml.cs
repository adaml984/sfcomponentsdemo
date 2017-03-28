using System;
using sf_sample.ViewModels.Popups;

namespace sf_sample.Views.Popups
{
    public partial class AutoCompleteConfigPopupView
    {
        public AutoCompleteConfigPopupView() { InitializeComponent(); }

        #region Overrides of PopupPage

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var viewModel = BindingContext as AutoCompleteConfigPopupViewModel;
            if (viewModel == null)
                throw new NullReferenceException("viewModel");

            suggestionModePicker.Items.Clear();
            foreach (var item in viewModel.SuggestionModeDictionary.Keys)
            {
                suggestionModePicker.Items.Add(item);
            }
            autocompleteModePicker.Items.Clear();
            foreach (var item in viewModel.AutoCompleteModeDictionary.Keys)
            {
                autocompleteModePicker.Items.Add(item);
            }
        }

        #endregion
    }
}