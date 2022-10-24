using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppKtuYbs
{
    public interface ISoapService
    {
        Task<kullaniciDTO> KimlikDogrula(string ogrenciNo, string sifre);
        Task<ogrenciAkademikYapiDTO> AkademikYapi(string ogrenciNo, string sifre);
        Task<OgrDersProgramiDTO> OgrenciDersProgrami(Int64 ogrenciId, string sifre);
    }
}
