using CA_UrunIslemleri.Concrete;

namespace CA_UrunIslemleri.Data
{
    public class AppUserData
    {
        public static List<AppUser> AppUserList = new List<AppUser>
        {
            new AppUser
            {
                ID= 1,
                FirstName = "Yusuf",
                LastName = "Tataroglu",
                Email = "yusuftataroglu97@gmail.com",
                Username = "admin",
                Password = "1234",
            },
            new AppUser
            {
                ID= 2,
                FirstName = "Aylin",
                LastName = "Aslantas",
                Email = "aylin.aslantas@gmail.com",
                Username = "ayln.asln",
                Password = "123456",
            },
            new AppUser
            {
                ID= 3,
                FirstName = "Yagmur",
                LastName = "Yaman",
                Email = "ygmr_yaman@gmail.com",
                Username = "yagmurymn",
                Password = "111222",
            }

        };
    }
}
