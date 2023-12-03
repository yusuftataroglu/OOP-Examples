using CA_Hamburger.Abstracts;
using CA_Hamburger.Data;
using CA_Hamburger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Concretes
{
    public class MenuConcrete : IMenu
    {
        public void GetMenu()
        {
            Console.WriteLine("Burger Otomasyona Hoşgeldiniz. Aşağıdan Menu seçin");
            foreach (Menu m in MenuData.MenuListesi)
            {
                Console.WriteLine(m);
            }
        }

        public void SelectMenu()
        {
            int secim = 0;
            try
            {
                Console.WriteLine("menu: ");
                secim = int.Parse(Console.ReadLine());
                foreach (Menu item in MenuData.MenuListesi)
                {
                    if (item.Id == secim)
                    {
                        Siparis.SeciliMenu = item;
                        Siparis.ToplamTutar+= item.Fiyat;
                        Console.WriteLine($"{Siparis.SeciliMenu.MenuAd} sepete eklendi!");
                        Console.WriteLine("*******************************************");

                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
