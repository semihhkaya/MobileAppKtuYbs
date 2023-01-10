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
    public partial class pHesap : ContentPage
    {
        public pHesap()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(A.Text);
            int b = Convert.ToInt32(B.Text);
            int c = Convert.ToInt32(C.Text);

            int delta = (b * b) - (4 * a * c);
            
            if(delta < 0)
            {
                DisplayAlert("Sonuç", "Reel Kök Yoktur.", "Tamam");
                return;
            }

            if (delta==0)
            {
                decimal x = -b / (2 * a);
                DisplayAlert("Sonuç", "x1 = " + x + ", x2 = " + x, "Tamam");
                return;
            }

            if (delta>0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                DisplayAlert("Sonuç", "x1 = " + x1 + " x2 = " + x2 , "Tamam");
            }
        }
    }
}