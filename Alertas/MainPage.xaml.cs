using MauiPopup;

namespace Alertas
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void DisplayAlert_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Display Alert", "Bienvenido a DotNet Maui", "OK", "Cancel");

        }

        private async void DisplayPrompt_Clicked(object sender, EventArgs e)
        {
            string datos = await DisplayPromptAsync("Display Prompt", "Bienvenido a DotNet Maui", "OK", "Cancel",
            "Ingresa tu edad");

        }

        private void PopUp_Clicked(object sender, EventArgs e)
        {
            PopupAction.DisplayPopup(new Popup());
        }
    }
}