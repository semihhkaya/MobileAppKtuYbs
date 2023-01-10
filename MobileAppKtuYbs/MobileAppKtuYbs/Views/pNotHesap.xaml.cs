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
    public partial class pNotHesap : ContentPage
    {
        public pNotHesap()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double arasinav = Convert.ToDouble(txtarasinavnot.Text);
            double arasinavoran = Convert.ToDouble(txtarasinavoran.Text);

            double final = Convert.ToDouble(txtfinalnot.Text);
            double finaloran = Convert.ToDouble(txtfinaloran.Text);

            double sonnot = arasinav * arasinavoran/100 + final * finaloran/100;
            genelort.Text = Convert.ToString(sonnot);
        }
    }
}