using Syncfusion.ListView.XForms.UWP;

namespace sf_sample.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            SfListViewRenderer.Init();
            LoadApplication(new sf_sample.App());
        }
    }
}