using System.Collections.Generic;
using Prism.Navigation;
using Syncfusion.SfAutoComplete.XForms;

namespace sf_sample.ViewModels.Popups
{
    public class AutoCompleteConfigPopupViewModel : BaseNavigableViewModel
    {
        private int _minimumPrefixCharacters = 0, _autocompleteModeSelectedIndex = 0, _suggestionsModeSelectedindex = 0;
        private SuggestionMode _selectedSuggestionMode;

        public AutoCompleteConfigPopupViewModel(INavigationService navigationService) : base(navigationService)
        {
            SuggestionModeDictionary = new Dictionary<string, SuggestionMode>()
            {
                {SuggestionMode.Contains.ToString(), SuggestionMode.Contains},
                {SuggestionMode.ContainsWithCaseSensitive.ToString(), SuggestionMode.ContainsWithCaseSensitive},
                {SuggestionMode.Custom.ToString(), SuggestionMode.Custom},
                {SuggestionMode.EndsWith.ToString(), SuggestionMode.EndsWith},
                {SuggestionMode.EndsWithCaseSensitive.ToString(), SuggestionMode.EndsWithCaseSensitive},
                {SuggestionMode.Equals.ToString(), SuggestionMode.Equals},
                {SuggestionMode.EqualsWithCaseSensitive.ToString(), SuggestionMode.EqualsWithCaseSensitive},
                {SuggestionMode.StartsWith.ToString(), SuggestionMode.StartsWith},
                {SuggestionMode.StartsWithCaseSensitive.ToString(), SuggestionMode.StartsWithCaseSensitive},
            };
            AutoCompleteModeDictionary = new Dictionary<string, AutoCompleteMode>()
            {
                {AutoCompleteMode.Append.ToString(), AutoCompleteMode.Append},
                {AutoCompleteMode.Suggest.ToString(), AutoCompleteMode.Suggest},
                {AutoCompleteMode.SuggestAppend.ToString(), AutoCompleteMode.SuggestAppend},
            };
            SuggestionsModeSelectedIndex = 0;
            AutoCompleteModeSelectedIndex = 0;
        }

        public int MinimumPrefixCharacters
        {
            get { return _minimumPrefixCharacters; }
            set { SetProperty(ref _minimumPrefixCharacters, value); }
        }

        public SuggestionMode SelectedSuggestionMode
        {
            get { return _selectedSuggestionMode; }
            set { SetProperty(ref _selectedSuggestionMode, value); }
        }

        public int AutoCompleteModeSelectedIndex
        {
            get { return _autocompleteModeSelectedIndex; }
            set { SetProperty(ref _autocompleteModeSelectedIndex, value); }
        }

        public int SuggestionsModeSelectedIndex
        {
            get { return _suggestionsModeSelectedindex; }
            set { SetProperty(ref _suggestionsModeSelectedindex, value); }
        }

        public Dictionary<string, AutoCompleteMode> AutoCompleteModeDictionary { get; }
        public Dictionary<string, SuggestionMode> SuggestionModeDictionary { get; }
    }
}