using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppKtuYbs
{
    public class SoapManager
    {
        ISoapService service;

        //ctor
        public SoapManager(ISoapService s)
        {
            service = s;
        }

        public Task<kullaniciDTO> KimlikDogrula(string ogrenciNo, string sifre)
        {
            return service.KimlikDogrula(ogrenciNo, sifre);
        }

        public async Task<MobileAppKtuYbs.ogrenciAkademikYapiDTO> AkademikYapi(string ogrenciNo, string sifre)
        {
            return await service.AkademikYapi(ogrenciNo, sifre);
        }

    }
}
