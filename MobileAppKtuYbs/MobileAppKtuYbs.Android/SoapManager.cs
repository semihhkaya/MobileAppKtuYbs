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
    public class SoapManager : ISoapService
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

        public async Task<kullaniciDTO> KimlikDogrula(string ogrenciNo, string sifre)
        {
            wsKTU.returnKimlikDogrulama sonuc = sClient.KimlikDogrula(auth, ogrenciNo, sifre);
            //kullaniciDTO ds = new kullaniciDTO();

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
                var info = MainActivity.mapper.Map<kullaniciDTO>(sonuc);
                return info;
            }

        }

        public async Task<MobileAppKtuYbs.ogrenciAkademikYapiDTO> AkademikYapi(string ogrenciNo, string sifre)
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
        public async Task<MobileAppKtuYbs.OgrDersProgramiDTO> OgrenciDersProgrami(Int64 ogrenciId, string sifre)
        {

            wsKTU.returnDersTakvim sonuc = sClient.OgrenciDersProgrami(auth, ogrenciId, sifre);
            //sonuc.Dersler[0].Saatler[0].
            if (sonuc.Hata)
            {
                // hata oluştu
                return new OgrDersProgramiDTO()
                {
                    Hata = true,
                    HataMesaji = sonuc.HataMesaji
                };
            }
            else
            {
                var dto = MainActivity.mapper.Map<OgrDersProgramiDTO>(sonuc);
                return dto;
            }

        }

        public async Task<MobileAppKtuYbs.DersNotDTO> OgrenviVizeNotlari(string ogrencino, string sifre)
        {

            wsKTU.returnDersNot sonuc = sClient.IOSVizeNotlarv2(auth, ogrencino, sifre, 1);
            //sonuc.Dersler[0].Saatler[0].
            if (sonuc.Hata)
            {
                // hata oluştu
                return new DersNotDTO()
                {
                    Hata = true,
                    HataMesaji = sonuc.HataMesaji
                };
            }
            else
            {
                var dto = MainActivity.mapper.Map<DersNotDTO>(sonuc);
                return dto;
            }

        }
    }
}