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
	public partial class SliderPage : ContentPage
	{
		public SliderPage ()
		{
			InitializeComponent ();
		}

	    private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
	    {
	        ValueLabel.Text = Math.Round(e.NewValue).ToString(CultureInfo.InvariantCulture);

	    }
	}
}