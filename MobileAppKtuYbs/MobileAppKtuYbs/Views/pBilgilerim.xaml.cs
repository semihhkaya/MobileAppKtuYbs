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
            adsoyad.Text = adsoyad.Text + App._kullanici.AdSoyad;
        }
    }
}