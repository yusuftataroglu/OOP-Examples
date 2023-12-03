using CA_Hamburger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Utils
{
    public static class FinalOrder
    {
        public static void WriteFinalOrder()
        {
            Console.WriteLine($"Siparişiniz oluşturuldu. Ödemeniz gereken toplam tutar: {Siparis.ToplamTutar} TL");
        }
    }
}
