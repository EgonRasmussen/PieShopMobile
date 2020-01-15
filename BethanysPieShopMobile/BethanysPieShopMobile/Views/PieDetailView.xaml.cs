using BethanysPieShopMobile.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PieDetailView : ContentPage
	{
		public Pie Pie { get; set; } 

		public PieDetailView (Pie p)
		{
			InitializeComponent ();

			//BindData(p);

			Pie = p;
			this.BindingContext = Pie;
		}

	    //private void BindData(Pie pie)
	    //{
	    //    PieNameLabel.Text = pie.PieName;
	    //    PieImage.Source = pie.ImageUrl;
	    //    DescriptionLabel.Text = pie.Description;
	    //    PriceLabel.Text = pie.Price.ToString("c");
		//    InStockLabel.Text = pie.InStock ? "In stock" : "Not in stock";
	    //}

	    private async void AddToBasketButton_OnClicked(object sender, EventArgs e)
	    {
	        await DisplayAlert("Success", "Pie added to baskey!", "Done");
        }
	}
}