using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_UrunIslemleri.Utils
{
    public class SubMenuAppUser
    {
        public static string SubMenuSelection { get; set; }
        public static bool Validation { get; set; }

        private static string[] AppUserMenu { get; } = new string[]
        {
            "1- Kullanicilari Goster",
            "2- Kullanicilari ID'ye Gore Goster",
            "3- Kullanici Olustur",
            "4- Kullanici Ara",
            "5- Kullanici Guncelle",
            "6- Kullanici Sil",
            "7- Kullanici Sayisini Goster"
        };
        public static void GetAppUserMenu()
        {
            foreach (string item in AppUserMenu)
            {
                Console.WriteLine(item);
            }
        }
        public static string SelectAppUserMenu()
        {
            Console.Write("Bir islem seciniz: ");
            SubMenuSelection = Console.ReadLine();
            return SubMenuSelection;
        }
        public static bool GetSelectedAppUserMenu()
        {
            if (SubMenuSelection != "1" && SubMenuSelection != "2" && SubMenuSelection != "3" && SubMenuSelection != "4" && SubMenuSelection != "5" && SubMenuSelection != "6" && SubMenuSelection != "7")
            {
                Message.FailureMessage("Lutfen gecerli bir secim yapiniz.");
                Validation = false;
                return Validation;
            }
            else
            {
                Validation = true;
                return Validation;
            }
        }
    }
}
