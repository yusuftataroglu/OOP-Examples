namespace CA_UrunIslemleri.Utils
{
    public class Menu
    {
        public static string MenuSelection { get; set; }
        public static bool Validation { get; set; }
        private static string[] MyMenu { get; } = new string[]
        {
            "1- Kullanici Islemleri",
            "2- Kategori Islemleri",
            "3- Musteri Islemleri",
            "4- Urun Islemleri",
            "5- Tedarikci Islemleri"
        };
        public static void GetMenu()
        {
            foreach (string item in MyMenu)
            {
                Console.WriteLine(item);
            }
        }
        public static string SelectMenu()
        {
            Console.Write("Bir islem seciniz: ");
            MenuSelection = Console.ReadLine();
            return MenuSelection;
        }
        public static bool GetSelectedMenu()
        {
            if (MenuSelection != "1" && MenuSelection != "2" && MenuSelection != "3" && MenuSelection != "4" && MenuSelection != "5")
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
