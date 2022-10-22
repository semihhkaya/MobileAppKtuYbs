﻿using System;
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
        public string ADSOYAD { get; set; }
        public string BOLUMADI { get; set; }
        public string DANISMAN { get; set; }
        public string FAKULTEADI { get; set; }
        public string PROGRAM { get; set; }
        public string RESIMURL { get; set; }
        public List<sinifDonemDTO> sinifDonem { get; set; }
        public Int32 SINIFI { get; set; }

    }
    public class sinifDonemDTO
    {
        public List<DersDurumDTO> Dersler  { get; set; }
        public string SINIFDONEM { get; set; }
    }
    public class DersDurumDTO
    {
        public bool Hata { get; set; }
        public string HataMesaji { get; set; }
        public string BASARI_DURUMU { get; set; }
        public string BASARI_NOTU { get; set; }
        public string DERS_ADI { get; set; }
        public Int64? DONEM { get; set; }
        public string DURUM_KODU { get; set; }
        public Int16? SINIF { get; set; }
        public string YAZILIM_SEKLİ { get; set; }
    }
}
