using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppKtuYbs
{
    public interface ISoapService
    {
        Task<kullaniciDTO> KimlikDogrula(string ogrenciNo, string sifre); //Tanımlama //bir manager sınıfında kullanacağım
        Task<ogrenciAkademikYapiDTO> AkademikYapi(string ogrenciNo, string sifre);
        Task<OgrDersProgramiDTO> OgrenciDersProgrami(Int64 ogrenciId, string sifre);
        Task<DersNotDTO> OgrenviVizeNotlari(string ogrencino, string sifre);
        Task<StringDTO> SifreDegistir(string ogrencino, string sifre, string yenisifre);
    }
}
