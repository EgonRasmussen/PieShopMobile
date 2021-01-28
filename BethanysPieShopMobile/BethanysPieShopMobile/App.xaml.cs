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

            //MainPage = new AppShell();

            //MainPage = new SettingsTableView();

            var alreadyRegistered = false;
            if (alreadyRegistered)
                MainPage = new AppShell();
            else
                MainPage = new NavigationPage(new LoginView());
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
