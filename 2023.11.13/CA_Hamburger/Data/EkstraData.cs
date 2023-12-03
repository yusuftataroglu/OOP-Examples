using CA_Hamburger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Data
{
    public class EkstraData
    {
        public static List<Ekstra> EkstraListesi = new List<Ekstra>()
        {
            new Ekstra{Id=1,EkstraAd="Ketçap",Fiyat=5},
            new Ekstra{Id=2,EkstraAd="Mayonez",Fiyat=7.5m},
            new Ekstra{Id=3,EkstraAd="Hardal",Fiyat=5},
            new Ekstra{Id=4,EkstraAd="Barbekü",Fiyat=7},


        };

        
    }
}
