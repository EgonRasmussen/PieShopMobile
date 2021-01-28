using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();
		}

        private void LoginButton_OnClicked(object sender, EventArgs e)
        {
			// Logik til authentication indsættes her
            Application.Current.MainPage = new AppShell();
        }
    }
}