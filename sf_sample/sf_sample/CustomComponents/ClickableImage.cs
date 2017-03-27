using System.Threading.Tasks;
using sf_sample.Commands;
using Xamarin.Forms;

namespace sf_sample.CustomComponents
{
    public class ClickableImage : Image
    {
        public static readonly BindableProperty ClickCommandProperty = BindableProperty.Create(
            "ClickCommand",
            typeof(CustomCommand),
            typeof(ClickableImage),
            null,
            BindingMode.TwoWay,
            propertyChanged: OnPropertyChanged);

        private TapGestureRecognizer GestureRecognizer { get; set; }

        public CustomCommand ClickCommand
        {
            get { return (CustomCommand) GetValue(ClickCommandProperty); }
            set { SetValue(ClickCommandProperty, value); }
        }

        private static void OnPropertyChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            var clickableImage = bindable as ClickableImage;
            if (clickableImage == null)
                return;
            var command = newvalue as CustomCommand;
            if (command == null)
                return;

            clickableImage.Source = command.Image;
            clickableImage.GestureRecognizer = new TapGestureRecognizer() {Command = command};
            clickableImage.GestureRecognizer.Tapped += async (s, e) =>
            {
                var image = s as ClickableImage;
                if (image == null)
                    return;
                image.Opacity = 0.2;
                await Task.Delay(200);
                image.Opacity = 1;
            };
            clickableImage.GestureRecognizers.Add(clickableImage.GestureRecognizer);
        }
    }
}