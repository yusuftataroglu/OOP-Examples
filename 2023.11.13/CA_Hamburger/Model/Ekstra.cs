using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Model
{
    public class Ekstra:BaseClass
    {
        public string EkstraAd { get; set; }
        public decimal Fiyat { get; set; }

        //Polymorphism: Class dışarıdan çağırıldığında hangi property'ler teslim edilecek?

        public override string ToString()
        {
            return EkstraAd + " " + Fiyat + " TL";
        }
    }
}
