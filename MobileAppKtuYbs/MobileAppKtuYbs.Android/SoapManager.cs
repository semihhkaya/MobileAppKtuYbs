using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppKtuYbs.Droid
{
    public class SoapManager : MobileAppKtuYbs.ISoapService
    {
        wsKTU.Service1 sClient;
        wsKTU.Authentication auth;
        public SoapManager()
        {
            sClient = new wsKTU.Service1();
            auth = new wsKTU.Authentication();
            auth.username = "android";
            auth.password = "CanKTU.2019";
        }
        public async Task<MobileAppKtuYbs.kullaniciDTO> KimlikDogrula(string ogrenciNo, string sifre)
        {

            wsKTU.returnKimlikDogrulama sonuc = sClient.KimlikDogrula(auth, ogrenciNo, sifre);
            if (sonuc.Hata)
            {
                // hata oluştu
                return new kullaniciDTO()
                {
                    Hata = true,
                    HataMesaji = sonuc.HataMesaji
                };
            }
            else
            {
                var dto = MainActivity.mapper.Map<kullaniciDTO>(sonuc);
                return dto;
            }

        }
        public async Task<MobileAppKtuYbs.ogrenciAkademikYapiDTO> OgrenciAkademikYapi(string ogrenciNo, string sifre)
        {

            wsKTU.returnOgrenciAkademikYapi sonuc = sClient.OgrenciAkademikYapi(auth, ogrenciNo, sifre);
            if (sonuc.Hata)
            {
                // hata oluştu
                return new ogrenciAkademikYapiDTO()
                {
                    Hata = true,
                    HataMesaji = sonuc.HataMesaji
                };
            }
            else
            {
                var dto = MainActivity.mapper.Map<ogrenciAkademikYapiDTO>(sonuc);
                return dto;
            }

        }
    }
}