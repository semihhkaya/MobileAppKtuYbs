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
    public partial class pLogin : ContentPage
    {
        public pLogin()
        {
            string no = txtOgrenciNo.Text;
            InitializeComponent();
            
        }
        //await çağırmak için async olması gerekiyor.

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string ogrencino = txtOgrenciNo.Text;
            if (ogrencino.Length > 6)
                ogrencino = ogrencino.Substring(0, 6);

            string sifre = txtSifre.Text;
            if (sifre.Length > 12)
                sifre = sifre.Substring(0, 12);

            kullaniciDTO s = await App.sManager.KimlikDogrula(ogrencino, sifre);

            if (s.Hata)
                DisplayAlert("Hata", s.HataMesaji, "Tamam");
            else
            {
                App._kullanici = s;
                App.Current.MainPage = new pMain();
            }

        }
    }
}