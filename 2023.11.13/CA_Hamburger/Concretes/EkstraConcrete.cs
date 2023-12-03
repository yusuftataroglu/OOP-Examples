using CA_Hamburger.Abstracts;
using CA_Hamburger.Data;
using CA_Hamburger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Concretes
{
    public class EkstraConcrete : IEkstra
    {
        public void GetEkstraMenu()
        {
            Console.WriteLine("Aşağıdan ekstra seçin. (birden fazla ekstra için , kullanın.)");
            for (int i = 0; i < EkstraData.EkstraListesi.Count; i++)
            {
                string extraName = $"{EkstraData.EkstraListesi[i].Id}-{EkstraData.EkstraListesi[i].EkstraAd}  {EkstraData.EkstraListesi[i].Fiyat}";
                Console.WriteLine(extraName);

            }
        }

        

        public void SelectEkstraMenu()
        {
            Console.WriteLine("Ekstra seçin:");
            string seciliEkstralar = Console.ReadLine();
            string[] ekstraSplit = seciliEkstralar.Split(',');
            for (int i = 0; i < ekstraSplit.Length; i++)
            {
                foreach (Ekstra item in EkstraData.EkstraListesi)
                {

                    //"1 2 3 3 4"
                    if (item.Id == int.Parse(ekstraSplit[i])) //bu işlem geçici bir çözüm.
                    {
                        Siparis.ToplamTutar += item.Fiyat;
                        Siparis.SeciliEkstralar.Add(item);
                        break;
                    }
                }
            }

            Console.WriteLine("Ekstralar sepete eklendi!");
            Console.WriteLine("****************************");
        }

        public string GetSelectedEkstrasNames()
        {
            string ekstraAdlari = "";

            if (Siparis.SeciliEkstralar.Count > 0)
            {
                foreach (Ekstra item in Siparis.SeciliEkstralar)
                {
                    ekstraAdlari += item.EkstraAd + " ";
                }
                return ekstraAdlari;
            }
            else
            {
                Console.WriteLine("Ekstra secilmedi.");
                return null;
            }
            
            
        }
    }
}
