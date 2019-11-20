using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView : ContentPage
    {
        public PopupView()
        {
            InitializeComponent();
        }

        private async void btnSimpleAlert_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

        private async void AlertYesNo_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Question?", "Would you like to play a game", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
        }

        private async void ActionSheetSimple_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
            Debug.WriteLine("Action: " + action);
        }

        private async void ActionSheetCancelDelete_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
            Debug.WriteLine("Action: " + action);
        }
    }
}