using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HepsiSurada
{
    internal class Islemci
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        private decimal _fiyat;
        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                if (value < 0)
                {
                    _fiyat = 0;
                }
                else
                {
                    _fiyat = value;
                }
            }
        }
    }
}
