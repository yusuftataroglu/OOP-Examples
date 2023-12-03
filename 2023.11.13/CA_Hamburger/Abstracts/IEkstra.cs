using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Hamburger.Abstracts
{
    public interface IEkstra
    {
        public void GetEkstraMenu();
        public void SelectEkstraMenu();
        public string GetSelectedEkstrasNames();
    }
}
