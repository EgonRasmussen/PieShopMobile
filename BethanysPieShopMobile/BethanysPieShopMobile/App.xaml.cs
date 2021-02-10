using Xamarin.Forms;

namespace BethanysPieShopMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StackLayoutPage();
            
            //MainPage = new GridLayoutPage();
            //MainPage = new NestedGridLayoutPage();

            //MainPage = new ScrollViewPage();
            //MainPage = new FlexLayoutPage(); 

            //MainPage = new LoginWithStackLayout();
            //MainPage = new LoginWithGridLayout();
            //MainPage = new RelativeLayoutPage();
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
