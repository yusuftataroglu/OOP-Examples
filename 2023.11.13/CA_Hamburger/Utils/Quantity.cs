using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Utils
{
    public static class Quantity
    {
        public static int GetQuantity()
        {
            int adet = 0;
            Console.Write("Adet miktarini giriniz: ");
            try
            {
                adet = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetQuantity();
            }
            return adet;

        }
    }
}
