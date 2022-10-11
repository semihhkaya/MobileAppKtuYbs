using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppKtuYbs
{
    public partial class App : Application
    {
        public static SoapManager sManager { get; set; }
        public static kullaniciDTO _kullanici = new kullaniciDTO();
        public App()
        {

            InitializeComponent();
            //MainPage = new MainPage();
            MainPage = new Views.pLogin();
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
