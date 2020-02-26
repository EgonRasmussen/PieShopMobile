using BethanysPieShopMobile.Model;
using System.ComponentModel;
using Xamarin.Forms;

namespace BethanysPieShopMobile
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public Pie CherryPie { get; set; }  // #4

        public MainPage()
        {
            InitializeComponent();

            // Oprettelse af Pie-objekt i koden
            CherryPie = new Pie
            {
                Id = 1,
                PieName = "Cherry Pie",
                Price = 20
            };

            this.BindingContext = CherryPie;
        }

        private void btnIncreasePrice_Clicked(object sender, System.EventArgs e)
        {
            CherryPie.Price++;
            DisplayAlert("Price increaced!", "Price = " + CherryPie.Price, "Ok");
        }
    }
}
