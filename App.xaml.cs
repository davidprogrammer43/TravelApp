using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TravelApp
{
    public partial class App : Application
    {
        public static string DatabaseLocation = String.Empty;
        public static string DatabaseLocation2 = string.Empty;


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string DatabaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            DatabaseLocation2 = DatabaseLocation; 

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
