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

            #region #1 BINDING IN CODE
            Binding pieNameBinding = new Binding();
            pieNameBinding.Source = pie;
            pieNameBinding.Path = "PieName";
            NameEntry.SetBinding(Entry.TextProperty, pieNameBinding);

            Binding priceBinding = new Binding();
            priceBinding.Source = pie;
            priceBinding.Path = "Price";
            PriceEntry.SetBinding(Entry.TextProperty, priceBinding);
            #endregion

            #region #3 BINDING VIA BINDINGCONTEXT
            //MainGrid.BindingContext = pie;
            #endregion

            #region #4 BINDING THE WHOLE PAGE
            //this.BindingContext = pie;
            #endregion
        }
    }
}
