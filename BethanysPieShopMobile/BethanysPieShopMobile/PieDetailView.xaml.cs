using BethanysPieShopMobile.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PieDetailView : ContentPage
	{
		public PieDetailView (Pie pie)
		{
			InitializeComponent ();
;
			this.BindingContext = pie;
		}

	    private async void AddToBasketButton_OnClicked(object sender, EventArgs e)
	    {
	        await DisplayAlert("Success", "Pie added to baskey!", "Done");
        }
	}
}