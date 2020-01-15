using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BethanysPieShopMobile.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PieDetailView : ContentPage
	{
		public PieDetailView (Pie p)
		{
			InitializeComponent ();

			//BindData(p);
			this.BindingContext = p;
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