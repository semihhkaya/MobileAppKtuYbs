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
            var sonuc = await App.sManager.AkademikYapi(App._ogrenciNo, App._sifre);
            //List<ogrenciAkademikYapiDTO> liste = new List<ogrenciAkademikYapiDTO>();
            listView.ItemsSource = sonuc.sinifDonem[0].Dersler;

        }
    }
}