using System;
using Xamarin.Forms;

namespace Zaehler
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private int _clickCount = 0;

        private void ClickMeButtonOnClicked(object sender, EventArgs e)
        {
            _clickCount++;
            CountLabel.Text = _clickCount == 1 ? "1 click" : $"{_clickCount} clicks";
            ResetButton.IsEnabled = true;
        }

        private async void ResetButtonOnClicked(object sender, EventArgs e)
        {
            var accepted = await DisplayAlert("Sure", "Do you want reset the counter?", "yes", "no");
            if (!accepted)
                return;
            _clickCount = 0;
            CountLabel.Text = "0 clicks";
            ResetButton.IsEnabled = false;

        }
    }
}
