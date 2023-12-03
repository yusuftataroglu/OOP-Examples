using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_UrunIslemleri.Utils
{
    public class SubMenuCategory
    {
        public static string SubMenuSelection { get; set; }
        public static bool Validation { get; set; }

        private static string[] CategoryMenu { get; } = new string[]
        {
            "1- Kategorileri Goster",
            "2- Kategorileri ID'ye Gore Goster",
            "3- Kategori Olustur",
            "4- Kategori Ara",
            "5- Kategori Guncelle",
            "6- Kategori Sil",
            "7- Kategori Sayisini Goster"
        };
        public static void GetCategoryMenu()
        {
            foreach (string item in CategoryMenu)
            {
                Console.WriteLine(item);
            }
        }
        public static string SelectCategoryMenu()
        {
            Console.Write("Bir islem seciniz: ");
            SubMenuSelection = Console.ReadLine();
            return SubMenuSelection;
        }
        public static bool GetSelectedCategoryMenu()
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
