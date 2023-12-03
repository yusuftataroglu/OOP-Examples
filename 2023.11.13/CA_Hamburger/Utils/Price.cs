using CA_Hamburger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Utils
{
    public static class Price
    {
        public static decimal GetTotalPrice(int adet)
        {
            Siparis.ToplamTutar *= adet;
            return Siparis.ToplamTutar;
        }
    }
}
