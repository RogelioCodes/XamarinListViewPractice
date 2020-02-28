using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lab2.View;
namespace Lab2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new FruitView()); //main page is a navigation page
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
