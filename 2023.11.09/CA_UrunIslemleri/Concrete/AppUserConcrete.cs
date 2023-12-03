using CA_UrunIslemleri.Abstract;
using CA_UrunIslemleri.Data;
using CA_UrunIslemleri.Utils;

namespace CA_UrunIslemleri.Concrete
{
    public class AppUserConcrete : IAppUser
    {
        public void Create()
        {
            try
            {
                AppUser appUser = new AppUser();
                Console.Write("Kullanici ID'si giriniz: ");
                appUser.ID = Convert.ToInt32(Console.ReadLine());
                foreach (AppUser item in AppUserData.AppUserList)
                {
                    if (item.ID == appUser.ID)
                    {
                        Message.FailureMessage("Bu ID'ye sahip bir kullanici mevcut!");
                        Create();
                    }
                    else
                    {
                        Console.Write("Adinizi giriniz: ");
                        appUser.FirstName = Console.ReadLine();
                        Console.Write("Soyadinizi giriniz: ");
                        appUser.LastName = Console.ReadLine();
                        Console.Write("E-mail adresinizi giriniz: ");
                        appUser.Email = Console.ReadLine();
                        Console.Write("Kullanici adinizi giriniz: ");
                        appUser.Username = Console.ReadLine();
                        Console.Write("Sifrenizi giriniz: ");
                        appUser.Password = Console.ReadLine();
                        AppUserData.AppUserList.Add(appUser);
                        Message.SuccessMessage("*****Kullanici eklendi.*****");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public void Delete()
        {
            int id = 0;
            Console.Write("Silinecek kullanicinin ID'sini giriniz: ");
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Delete();
            }
            foreach (AppUser item in AppUserData.AppUserList)
            {
                if (item.ID == id)
                {
                    AppUserData.AppUserList.Remove(item);
                    Message.SuccessMessage("*****Kullanici silindi.*****");
                    break;
                }
            }
            Message.InfoMessage("-----Boyle bir kullanici bulunamadı.-----");

        }

        public void GetAppUserList()
        {
            Console.WriteLine("------AppUser List------");
            foreach (AppUser appUser in AppUserData.AppUserList)
            {
                Console.WriteLine(appUser.ToString());
            }
        }

        public AppUser GetById()
        {
            int id = 0;
            Console.Write("Kullanici ID'sini giriniz: ");
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetById();
            }
            foreach (AppUser appUser in AppUserData.AppUserList)
            {
                if (appUser.ID == id)
                {
                    return appUser;
                }
            }
            Message.InfoMessage("-----Kullanici bulunamadi.-----");
            return null;
        }

        public AppUser SearchAppUser()
        {
            Console.Write("Kullanici soyadini giriniz: ");
            string appUserLastname = Console.ReadLine();
            foreach (AppUser appUser in AppUserData.AppUserList)
            {
                if (appUser.LastName == appUserLastname)
                {
                    return appUser;
                }
            }
            Message.InfoMessage("-----Kullanici bulunamadi.-----");
            return null;
        }

        public int TotalAppUser()
        {
            return AppUserData.AppUserList.Count;
        }

        public void Update()
        {
            AppUser updatedAppUser = new AppUser();
            Console.Write("Guncellemek istediginiz kullanicinin ID'sini giriniz: ");
            try
            {
                updatedAppUser.ID = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Update();
            }
            foreach (AppUser appUser in AppUserData.AppUserList)
            {
                if (appUser.ID == updatedAppUser.ID)
                {
                    appUser.ID = updatedAppUser.ID;
                    Console.Write("Adinizi giriniz: ");
                    appUser.FirstName = Console.ReadLine();
                    Console.Write("Soyadinizi giriniz: ");
                    appUser.LastName = Console.ReadLine();
                    Console.Write("E-mail adresinizi giriniz: ");
                    appUser.Email = Console.ReadLine();
                    Console.Write("Kullanici adinizi giriniz: ");
                    appUser.Username = Console.ReadLine();
                    Console.Write("Sifrenizi giriniz: ");
                    appUser.Password = Console.ReadLine();
                    Message.SuccessMessage("*****Kullanici bilgileri guncellendi.*****");
                    break;
                }
            }
            Message.InfoMessage("-----Kullanici bulunamadi.-----");
        }

    }
}
