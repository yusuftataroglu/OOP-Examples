using CA_UrunIslemleri.Concrete;
using CA_UrunIslemleri.Utils;


CategoryConcrete category = new CategoryConcrete();
AppUserConcrete appUser = new AppUserConcrete();

while (true)
{
    Login.GetLoginMenu();
    Login.CheckInfos(Login.Username, Login.Password);
    if (Login.Validation) break;
    else continue;
}


while (true)
{
    Menu.GetMenu();
    Menu.SelectMenu();
    Menu.GetSelectedMenu();
    if (Menu.Validation)
    {
        switch (Menu.MenuSelection)
        {
            case "1":
                SubMenuAppUser.GetAppUserMenu();
                SubMenuAppUser.SelectAppUserMenu();
                SubMenuAppUser.GetSelectedAppUserMenu();
                switch (SubMenuAppUser.SubMenuSelection)
                {
                    case "1":
                        appUser.GetAppUserList();
                        break;
                    case "2":
                        Console.WriteLine(appUser.GetById());
                        break;
                    case "3":
                        appUser.Create();
                        break;
                    case "4":
                        Console.WriteLine(appUser.SearchAppUser());
                        break;
                    case "5":
                        appUser.Update();
                        break;
                    case "6":
                        appUser.Delete();
                        break;
                    case "7":
                        Console.WriteLine(appUser.TotalAppUser());
                        break;
                    default:
                        break;
                }
                break;
            case "2":
                SubMenuCategory.GetCategoryMenu();
                SubMenuCategory.SelectCategoryMenu();
                SubMenuCategory.GetSelectedCategoryMenu();
                switch (SubMenuCategory.SubMenuSelection)
                {
                    case "1":
                        category.GetCategoryList();
                        break;
                    case "2":
                        Console.WriteLine(category.GetById());
                        break;
                    case "3":
                        category.Create();
                        break;
                    case "4":
                        Console.WriteLine(category.SearchCategory());
                        break;
                    case "5":
                        category.Update();
                        break;
                    case "6":
                        category.Delete();
                        break;
                    case "7":
                        Console.WriteLine(category.TotalCategory());
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }
    };
}




Console.Read();