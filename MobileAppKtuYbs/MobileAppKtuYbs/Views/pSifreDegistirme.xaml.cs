using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppKtuYbs.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pSifreDegistirme : ContentPage
    {
        public pSifreDegistirme()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string sifre = txtSifre.Text;
            string yenisifre = txtYeniSifre.Text;
            string yenisifre2 = txtYeniSifre2.Text;

            if (String.IsNullOrEmpty(sifre))
            {
                DisplayAlert("Uyarı", "Şifre Alanı Boş Geçilemez", "Tamam");
                return; //Methoddan çıkılmasını sağladık. Devam eden kodların çalışmasını engelledik.
            }

            if (String.IsNullOrEmpty(yenisifre))
            {
                DisplayAlert("Uyarı", "Yeni Şifre Alanı Boş Geçilemez", "Tamam");
                return; //Methoddan çıkılmasını sağladık. Devam eden kodların çalışmasını engelledik.
            }

            if (String.IsNullOrEmpty(yenisifre2))
            {
                DisplayAlert("Uyarı", "Yeni Şifre Tekrar Alanı Boş Geçilemez", "Tamam");
                return; //Methoddan çıkılmasını sağladık. Devam eden kodların çalışmasını engelledik.
            }
            if (yenisifre != yenisifre2)
            {
                DisplayAlert("Uyarı", "Yeni Şifreler Eşleşmiyor!", "Tamam");
                return;
            }
            if (sifre != App._sifre)
            {
                DisplayAlert("Uyarı", "Mevcut Şifreniz Hatalıdır", "Tamam");
                return;
            }

            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,15}$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(yenisifre))
            {
                DisplayAlert("Uyarı", "Şifreniz Kurallara Uygun Olsun", "Tamam");
                return;
            }

            var sonuc = await App.sManager.SifreDegistir(App._ogrenciNo, sifre, yenisifre);

            if (sonuc.Hata)
            {
                DisplayAlert("Hata", sonuc.HataMesaji, "Tamam");
                return;
            }

            App._sifre = yenisifre;
            DisplayAlert("Başarılı", "Şifreniz Değiştirilmiştir", "Tamam");
           
        }
    }
}