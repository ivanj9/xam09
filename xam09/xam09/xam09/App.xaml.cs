using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xam09.Services;
using xam09.Views;

namespace xam09
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
