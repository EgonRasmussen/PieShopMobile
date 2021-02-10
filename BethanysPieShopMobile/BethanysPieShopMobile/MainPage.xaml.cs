using BethanysPieShopMobile.Model;
using System.ComponentModel;
using Xamarin.Forms;

namespace BethanysPieShopMobile
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Oprettelse af Pie-objekt i koden
            Pie pie = new Pie
            {
                Id = 1,
                PieName = "Cherry Pie",
                Price = 20
            };

            MainGrid.BindingContext = pie;

            //this.BindingContext = pie;
        }
    }
}
