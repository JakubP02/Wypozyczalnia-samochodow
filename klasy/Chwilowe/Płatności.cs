using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaAut
{
    internal class Płatności
    {
        public int Id { get; set; }
        public decimal Kwota { get; set; }
        public string TypPlatnosci { get; set; }
        public string Podmiot { get; set; }
        public DateTime DataPlatnosci { get; set; }
    }
}
