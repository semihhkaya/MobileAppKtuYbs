using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppKtuYbs
{
    public class kullaniciDTO
    {
        //http://193.140.168.236/WSAndroid/Service1.asmx
        public bool Hata { get; set; }
        public string HataMesaji { get; set; }
        public Int64 OgrId { get; set; }
        public string OgrenciNo { get; set; }
        public string AdSoyad { get; set; }
        public Int32 Sinifi { get; set; }
        public Int64 KayitNedeniKod { get; set; }
        public string KayitNedeniAck { get; set; }
        public string KayitTarihi { get; set; }
        public Int64 AyrilisNedeniKod { get; set; }
        public string AyrilisNedeniAck { get; set; }
        public string AyrilisTarihi { get; set; }
        public string FakulteAdi { get; set; }
        public string BolumAdi { get; set; }
        public string Program { get; set; }
        public Int64 FakulteSatirId { get; set; }
        public Int64 BolumSatirId { get; set; }
        public Int64 ProgramSatirId { get; set; }
        public string Danisman { get; set; }
        public string DanismanEPosta { get; set; }
        public string ResimURL { get; set; }
        public string OgrenimDurumu { get; set; }
        public string YoksisDurum { get; set; }
        public string DigerEposta { get; set; }
        public string CepTel { get; set; }
        public string HesKodu { get; set; }
    }
    public class ogrenciAkademikYapiDTO
    {
        public bool Hata { get; set; }
        public string HataMesaji { get; set; }
        public string AdSoyad { get; set; }
        public string BolumAdi { get; set; }
        public string Danisman { get; set; }
        public string FakulteAdi { get; set; }
        public string Program { get; set; }
        public string ResimUrl { get; set; }
        public int Sinif { get; set; }
        public List<sinifDonemDTO> sinifDonem { get; set; }
    }
    public class sinifDonemDTO
    {
        public List<DersDurumDTO> Dersler  { get; set; }
        public string SinifDonem { get; set; }
    }
    public class DersDurumDTO
    {
        public bool Hata { get; set; }
        public string HataMesaji { get; set; }
        public string BasariDurumu { get; set; }
        public string BasariNotu { get; set; }
        public string DersAdi { get; set; }
        public Int64? Donem { get; set; }
        public string DurumKodu { get; set; }
        public Int16? Sinif { get; set; }
        public string YazilimSekli { get; set; }
    }
}
