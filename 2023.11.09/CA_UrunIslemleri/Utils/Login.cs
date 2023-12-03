using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Utils
{
    public class Login
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static bool Validation { get; set; }
        public static void GetLoginMenu()
        {
            Console.Write("Kullanici adinizi giriniz: ");
            Username = Console.ReadLine();
            Console.Write("Sifrenizi giriniz: ");
            Password = Console.ReadLine();
        }

        public static bool CheckInfos(string username, string password)
        {
            if (username != "admin" || password != "1234")
            {
                Message.FailureMessage("Kullanici bilgileri hatali!\n");
                Validation = false;
                return Validation;
            }
            else
            {
                Message.SuccessMessage("Giris basarili. Hos geldiniz!\n");
                Validation = true;
                return Validation;
            }
        }
    }
}
