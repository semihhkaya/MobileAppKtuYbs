using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppKtuYbs
{
    public class SoapManager
    {
        ISoapService service;

        public SoapManager(ISoapService s)
        {
            service = s;
        }

        public Task<kullaniciDTO> KimlikDogrula(string ogrenciNo, string sifre)
        {
            return service.KimlikDogrula(ogrenciNo, sifre);
        }

    }
}
