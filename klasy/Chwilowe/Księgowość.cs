using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaAut
{
    internal class Księgowość
    {
        public int IdMiesiaca { get; set; }
        public int Rok { get; set; }
        public decimal Przychody { get; set; }
        public decimal NależnyPodatek { get; set; }
        public decimal PensjePracownikow { get; set; }
        public decimal Koszty { get; set; }
        public decimal Zysk { get; set; }
    }
}
