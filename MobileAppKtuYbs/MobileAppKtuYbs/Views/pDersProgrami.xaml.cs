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
    public partial class pDersProgrami : ContentPage
    {
        public pDersProgrami()
        {
            InitializeComponent();
            DP();


        }
        public async void DP()
        {
            OgrDersProgramiDTO sonuc = await App.sManager.OgrenciDersProgrami(App._kullanici.OgrId, App._sifre);
            dersProgrami.ItemsSource = sonuc.Dersler;
        }
    }
}