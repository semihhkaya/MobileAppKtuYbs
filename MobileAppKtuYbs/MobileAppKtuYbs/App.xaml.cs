using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppKtuYbs
{
    public partial class App : Application
    {
        public static SoapManager sManager { get; set; }
        public static kullaniciDTO _kullanici = new kullaniciDTO();
        public static string _ogrenciNo, _sifre;

        public static ogrenciAkademikYapiDTO _akademikYapiKullanici = new ogrenciAkademikYapiDTO();
        public static List<sinifDonemDTO> _sinifDonemKullanici = new List<sinifDonemDTO>();
        public static List<DersDurumDTO> _dersDurumKullanici = new List<DersDurumDTO>();
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
