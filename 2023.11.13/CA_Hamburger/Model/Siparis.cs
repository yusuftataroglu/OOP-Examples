using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Model
{
    public class Siparis : BaseClass
    {
        public static Menu SeciliMenu { get; set; }

        public static List<Ekstra> SeciliEkstralar = new List<Ekstra>();
        public static decimal ToplamTutar { get; set; }

    }
}
