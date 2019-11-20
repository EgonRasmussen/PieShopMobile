using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BethanysPieShopMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LabelButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new LabelPage());
        }

        private void ImageViewPageButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ImageViewPage());
        }

        private void ButtonPageButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ButtonPage());
        }

        private void EntryPageButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new EntryPage());
        }

        private void SliderPageButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new SliderPage());
        }

        private void TimeAndDatePageButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TimeAndDatePickerPage());
        }

        private void OtherViewPageButton_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new OtherViewPage());
        }
    }
}
