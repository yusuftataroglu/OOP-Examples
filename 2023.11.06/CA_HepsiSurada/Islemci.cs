using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HepsiSurada
{
    internal class Islemci:Bilgisayar
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public override decimal IndirimYap()
        {
            if (Marka.ToLower() == "amd")
            {
                return Fiyat * (1M - 0.10M);
            }
            else
            {
                return base.IndirimYap();
            }
        }


    }
}
