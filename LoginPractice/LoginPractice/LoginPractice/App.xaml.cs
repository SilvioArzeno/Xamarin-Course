using LoginPractice.Models;
using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginPractice
{
    public partial class App : Application
    {
        public static string DatabaseLocation { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
        public App(string databaseLocation)
        {

            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
            DatabaseLocation = databaseLocation;
        }

        protected override void OnStart()
        {
            base.OnStart();


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
