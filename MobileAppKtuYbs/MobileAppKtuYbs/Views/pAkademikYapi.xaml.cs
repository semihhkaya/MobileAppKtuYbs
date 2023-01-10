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
            ogrenciAkademikYapiDTO sonuc = await App.sManager.AkademikYapi(App._ogrenciNo, App._sifre); //vERİ BURDA GELİR
            
            listView.ItemsSource = sonuc.sinifDonem; //OGRENCİAKADEMİKYAPİDTO.SİNİFDONEM ->DERSLER,SINIFDONEM
                                                     //
            


        }
    }
}