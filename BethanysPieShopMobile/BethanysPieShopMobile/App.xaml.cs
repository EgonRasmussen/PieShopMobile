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

            MainPage = new LoginView();
            //MainPage = new RegisterView();
            //MainPage = new ContactView();
            //MainPage = new SettingsView();
            //MainPage = new WebPageView();
            //MainPage = new PieDetailView();
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
