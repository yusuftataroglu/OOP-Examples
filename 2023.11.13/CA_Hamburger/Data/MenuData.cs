using CA_Hamburger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Data
{
    public class MenuData
    {
        public static List<Menu> MenuListesi = new List<Menu>()
        {
            new Menu{Id=1,MenuAd="Whooper",Fiyat=100},
            new Menu{Id=2,MenuAd="BigMc",Fiyat=150},
            new Menu{Id=3,MenuAd="McTurco",Fiyat=175}

        };
    }
}
