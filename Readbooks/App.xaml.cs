using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Readbooks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("ios=937f0ed9-1d75-4b62-abf1-133b54788b58;"
                + "android=3c20d9c9-1803-4301-8bc8-8150c1b207b2",
                typeof(Analytics),typeof(Crashes));
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
