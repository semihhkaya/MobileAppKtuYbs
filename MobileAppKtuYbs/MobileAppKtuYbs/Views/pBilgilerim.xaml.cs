using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppKtuYbs.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pBilgilerim : ContentPage
    {
        public pBilgilerim()
        {
            InitializeComponent();
            nameSurname.Text = App._kullanici.AdSoyad;
            studentNumber.Text = Convert.ToString(App._kullanici.OgrId);
            faculty.Text = App._kullanici.FakulteAdi;
            string uriImage = App._kullanici.ResimURL;
            imagex.Source = new UriImageSource
            {
                Uri = new Uri(uriImage),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(3,0,0,0)
            };
        }

    }
}