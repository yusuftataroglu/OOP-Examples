using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HepsiSurada
{
    internal class EkranKarti:Bilgisayar
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public override decimal IndirimYap()
        {
            return base.IndirimYap();
        }
    }
}
