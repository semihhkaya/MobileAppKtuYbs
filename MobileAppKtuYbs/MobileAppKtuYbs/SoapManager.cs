using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppKtuYbs
{
    public class SoapManager
    {
        ISoapService service;

        //ctor //Consructor //Yapıcı blok //Inheritance
        public SoapManager(ISoapService s)
        {
            service = s;
        }

        public Task<kullaniciDTO> KimlikDogrula(string ogrenciNo, string sifre)
        {
            return service.KimlikDogrula(ogrenciNo, sifre); //Emir vermek //Açıklama yazmak

        }
        public async Task<MobileAppKtuYbs.ogrenciAkademikYapiDTO> AkademikYapi(string ogrenciNo, string sifre)
        {
            return await service.AkademikYapi(ogrenciNo, sifre);
        }

        public Task<OgrDersProgramiDTO> OgrenciDersProgrami(Int64 ogrenciId, string sifre)
        {
            return service.OgrenciDersProgrami(ogrenciId, sifre);
        }
        
        public Task<MobileAppKtuYbs.DersNotDTO> OgrenviVizeNotlari(string ogrencino, string sifre)
        {
            return service.OgrenviVizeNotlari(ogrencino, sifre);
        }

        public Task<MobileAppKtuYbs.StringDTO> SifreDegistir(string ogrencino, string sifre, string yenisifre)
        {
            return service.SifreDegistir(ogrencino, sifre, yenisifre);
        }
    }
}
