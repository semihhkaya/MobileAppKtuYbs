using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace MobileAppKtuYbs.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pBilgilerim : ContentPage
    {
        public pBilgilerim()
        {
            //kullaniciDTO kullaniciDTO = App._kullanici;
            InitializeComponent();
            adsoyad.Text = App._kullanici.AdSoyad;























            //nameSurname.Text = App._kullanici.AdSoyad;
            //studentNumber.Text = App._ogrenciNo;
            //faculty.Text = App._kullanici.FakulteAdi;
            //department.Text = App._kullanici.BolumAdi;
            //program.Text = App._kullanici.Program;
            //cclass.Text = Convert.ToString(App._kullanici.Sinifi);
            //eposta.Text = App._kullanici.DigerEposta;
            //tel.Text = App._kullanici.CepTel;
            //status.Text = App._kullanici.OgrenimDurumu;

            //string uriImage = App._kullanici.ResimURL;
            //imagex.Source = new UriImageSource
            //{
            //    Uri = new Uri(uriImage),
            //    CachingEnabled = true,
            //    CacheValidity = new TimeSpan(3,0,0,0)
            //};
        }

    }
}
//< !--< ScrollView >
//            < ScrollView.Content >
//        < StackLayout Padding = "0,5,0,0" BackgroundColor = "#1e6f97" >



//            < Frame Padding = "0" HeightRequest = "100" WidthRequest = "100" BackgroundColor = "White"
//                   CornerRadius = "100" BorderColor = "Teal" HorizontalOptions = "Center"
//                   VerticalOptions = "Center" >
//                < Frame.Content >
//                    < Image x: Name = "imagex" Aspect = "AspectFill" ></ Image >
//                </ Frame.Content >
//            </ Frame >


//            < Frame HasShadow = "False" CornerRadius = "40" HeightRequest = "100" Margin = "0" VerticalOptions = "FillAndExpand" BackgroundColor = "AntiqueWhite" >
//            < Grid >
//                < Grid.RowDefinitions >
//                    < RowDefinition Height = "35" />
//                    < RowDefinition Height = "35" />
//                    < RowDefinition Height = "35" />
//                    < RowDefinition Height = "35" />
//                    < RowDefinition Height = "35" />
//                    < RowDefinition Height = "35" />
//                    < RowDefinition Height = "35" />
//                    < RowDefinition Height = "35" />
//                    < RowDefinition Height = "35" />
//                    < RowDefinition Height = "60" />
//                </ Grid.RowDefinitions >
//                < Grid.ColumnDefinitions >
//                    < ColumnDefinition Width = "100" />
//                    < ColumnDefinition Width = "300" />
//                </ Grid.ColumnDefinitions >



//                < Label Text = "Ad Soyad:" Grid.Row = "0" Grid.Column = "0" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#4a9bc3" ></ Label >
//                < Label x: Name = "nameSurname" Text = "" Grid.Row = "0" Grid.Column = "1" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#115c81" />



//                < Label Text = "Öğrenci No:" Grid.Row = "1" Grid.Column = "0" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#4a9bc3" ></ Label >
//                < Label x: Name = "studentNumber" Text = "" Grid.Row = "1" Grid.Column = "1" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#115c81" ></ Label >

//                < Label Text = "Fakülte:" Grid.Row = "2" Grid.Column = "0" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#4a9bc3" ></ Label >
//                < Label x: Name = "faculty" Text = "" Grid.Row = "2" Grid.Column = "1" Grid.RowSpan = "2" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#115c81" ></ Label >

//                < Label Text = "Bölüm:" Grid.Row = "4" Grid.Column = "0" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#4a9bc3" ></ Label >
//                < Label x: Name = "department" Text = "" Grid.Row = "4" Grid.Column = "1"  FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#115c81" ></ Label >

//                < Label Text = "Program:" Grid.Row = "5" Grid.Column = "0" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#4a9bc3" ></ Label >
//                < Label x: Name = "program" Text = "" Grid.Row = "5" Grid.Column = "1"  FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#115c81" ></ Label >


//                < Label Text = "Sınıf:" Grid.Row = "6" Grid.Column = "0" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#4a9bc3" ></ Label >
//                < Label x: Name = "cclass" Text = "" Grid.Row = "6" Grid.Column = "1"  FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#115c81" ></ Label >


//                < Label Text = "E-Posta:" Grid.Row = "7" Grid.Column = "0" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#4a9bc3" ></ Label >
//                < Label x: Name = "eposta" Text = "" Grid.Row = "7" Grid.Column = "1"  FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#115c81" ></ Label >


//                < Label Text = "Telefon:" Grid.Row = "8" Grid.Column = "0" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#4a9bc3" ></ Label >
//                < Label x: Name = "tel" Text = "" Grid.Row = "8" Grid.Column = "1"  FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#115c81" ></ Label >


//                < Label Text = "Öğrenim Durumu:" Grid.Row = "9" Grid.Column = "0" FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#4a9bc3" ></ Label >
//                < Label x: Name = "status" Text = "" Grid.Row = "9" Grid.Column = "1" Grid.RowSpan = "2"  FontSize = "Medium" FontAttributes = "Bold"  TextColor = "#115c81" ></ Label >


//            </ Grid >
//            </ Frame >
//        </ StackLayout >
//            </ ScrollView.Content >
//        </ ScrollView > -->