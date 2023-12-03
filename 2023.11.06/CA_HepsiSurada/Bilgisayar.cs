using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_HepsiSurada
{
    internal class Bilgisayar
    {
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
        public Anakart Anakart { get; set; }
        public Islemci Islemci { get; set; }
        public EkranKarti EkranKarti { get; set; }

        public virtual decimal IndirimYap()
        {
            return _fiyat*1;
        }

    }
}
