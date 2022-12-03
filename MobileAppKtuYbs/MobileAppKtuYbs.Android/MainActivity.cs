using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using AutoMapper;

namespace MobileAppKtuYbs.Droid
{
    [Activity(Label = "MobileAppKtuYbs", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static IMapper mapper;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<wsKTU.returnKimlikDogrulama, kullaniciDTO>();

                cfg.CreateMap<wsKTU.returnOgrenciAkademikYapi, ogrenciAkademikYapiDTO>();
                cfg.CreateMap<wsKTU.SinifDonem, sinifDonemDTO>();
                cfg.CreateMap<wsKTU.DersDurum, DersDurumDTO>();
                cfg.CreateMap<wsKTU.returnDersTakvim, OgrDersProgramiDTO>();
                cfg.CreateMap<wsKTU.DersTakvim, DersTakvimDTO>();
                cfg.CreateMap<wsKTU.DersTakvimGun, DersTakvimGunDTO>();

                cfg.CreateMap<wsKTU.returnDersNot, DersNotDTO>();
                cfg.CreateMap<wsKTU.Ders, DersDTO>();
                cfg.CreateMap<wsKTU.Sinav, SinavDTO>();


            });
            mapper = configuration.CreateMapper();

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            App.sManager = new MobileAppKtuYbs.SoapManager(new SoapManager());

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}