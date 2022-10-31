using System;
using System.Collections.Generic;
using System.Text;

namespace MobileAppKtuYbs
{
    public class classMethods
    {
        public static string GunAdi(int a)
        {
            string gunadi = null;

            switch (a)
            {
                case 1:
                    gunadi = "Pazartesi";
                    break;
                case 2:
                    gunadi = "Salı";
                    break;
                case 3:
                    gunadi = "Çarşamba";
                    break;
                case 4:
                    gunadi = "Perşembe";
                    break;
                case 5:
                    gunadi = "Cuma";
                    break;
                case 6:
                    gunadi = "Cumartesi";
                    break;
                case 7:
                    gunadi = "Pazar";
                    break;
                default:
                    break;
            }
            return gunadi;
        }

        public static string DersSaat(int a)
        {
            string derssaat = null;

            switch (a)
            {
                case 1:
                    derssaat = "08:00 - 09:00";
                    break;
                case 2:
                    derssaat = "09:00 - 10:00";
                    break;
                case 3:
                    derssaat = "10:00 - 11:00";
                    break;
                case 4:
                    derssaat = "11:00 - 12:00";
                    break;
                case 5:
                    derssaat = "12:00 - 13:00";
                    break;
                case 6:
                    derssaat = "13:00 - 14:00";
                    break;
                case 7:
                    derssaat = "14:00 - 15:00";
                    break;
                case 8:
                    derssaat = "15:00 - 16:00";
                    break;
                case 9:
                    derssaat = "16:00 - 17:00";
                    break;
                case 10:
                    derssaat = "17:00 - 18:00";
                    break;
                case 11:
                    derssaat = "18:00 - 19:00";
                    break;
                case 12:
                    derssaat = "19:00 - 20:00";
                    break;
                case 13:
                    derssaat = "20:00 - 21:00";
                    break;
                case 14:
                    derssaat = "21:00 - 22:00";
                    break;
                case 15:
                    derssaat = "23:00 - 00:00";
                    break;
                case 16:
                    derssaat = "00:00 - 01:00";
                    break;
                default:
                    break;
            }
            return derssaat;
        }

    }
}
