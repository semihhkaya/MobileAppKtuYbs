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
    public partial class pGeriBildirim : ContentPage
    {
        public pGeriBildirim()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        //write me a c# code that take statement and replace first letter with upper character in all sentences
        //write me
        private void Editor_TextChanged(object sender, TextChangedEventArgs e)
        {
            string metin = editor.Text; //Mesajdaki ilk harfi büyütüyoruz.

            if (!string.IsNullOrEmpty(metin)) //Editörde bir metin null değilse ilk karakterini kontrol et.
            {
                string basharf = metin[0].ToString().ToUpper();
                metin = basharf + metin.Remove(0, 1);
                editor.Text = metin;
            }

        }
    }
}