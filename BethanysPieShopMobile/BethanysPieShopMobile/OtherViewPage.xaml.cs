using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OtherViewPage : ContentPage
	{
		public OtherViewPage ()
		{
			InitializeComponent ();
		}

	    private void MainStepper_OnValueChanged(object sender, ValueChangedEventArgs e)
	    {
	        ValueLabel.Text = e.NewValue.ToString(CultureInfo.InvariantCulture);
	    }
	}
}