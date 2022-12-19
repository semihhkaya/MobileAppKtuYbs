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
    public partial class pVizeNotlari : ContentPage
    {
        public pVizeNotlari()
        {
            InitializeComponent();

            VN();
        }
        public async void VN()
        {
            DersNotDTO sonuc = await App.sManager.OgrenviVizeNotlari(App._ogrenciNo, App._sifre);

            vizeList.ItemsSource = sonuc.DersNotlar;
        }
    }
}