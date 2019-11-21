using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new MainPage();

            MainPage = new StackLayoutPage();
            //MainPage = new LoginWithStackLayout();

            //MainPage = new GridLayoutPage();
            //MainPage = new NestedGridLayoutPage();
            //MainPage = new LoginWithGridLayout();

            //MainPage = new RelativeLayoutPage();
            //MainPage = new ScrollViewPage();
            //MainPage = new FlexLayoutPage();     
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
