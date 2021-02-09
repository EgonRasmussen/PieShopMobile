using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LargeImagePageView : ContentPage
    {
        public LargeImagePageView()
        {
            InitializeComponent();
        }

        private async void btnOK_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}