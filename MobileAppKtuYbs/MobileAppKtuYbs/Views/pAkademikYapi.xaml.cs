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
    public partial class pAkademikYapi : ContentPage
    {
        public pAkademikYapi()
        {
            InitializeComponent();
            AY();

        }
        public async void AY()
        {

            //tekrar bak.

            ogrenciAkademikYapiDTO sonuc = await App.sManager.AkademikYapi(App._ogrenciNo, App._sifre);

            listView.ItemsSource = sonuc.sinifDonem;
            


        }
    }
}