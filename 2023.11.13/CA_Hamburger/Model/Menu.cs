using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Model
{
    public class Menu: BaseClass
    {
        
        public string MenuAd { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return Id+" "+MenuAd + " " + Fiyat + " TL";
        }

    }
}
