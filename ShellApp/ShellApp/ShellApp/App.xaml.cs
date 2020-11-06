using ShellApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ShellViewPage();
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
