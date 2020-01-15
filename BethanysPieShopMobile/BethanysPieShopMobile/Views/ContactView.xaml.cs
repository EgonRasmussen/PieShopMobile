using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactView : ContentPage
	{
		public ContactView ()
		{
			InitializeComponent ();
		}

	    private void SendMessageButton_OnClicked(object sender, EventArgs e)
	    {
	        DisplayAlert("Success", "Message sent successfully", "Done");

        }

	    private void ContactMeSwitch_OnToggled(object sender, ToggledEventArgs e)
	    {
	        //handle the switch change here
	    }
	}
}