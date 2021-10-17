using Module38.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module38
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new WebPage();
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
