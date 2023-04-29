using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaAut
{
    internal class Wypożyczenia
    {
        public int Id { get; set; }
        public Klient IdClienta { get; set; }
        public DateTime DataRozpoczecia { get; set; }
        public DateTime DataZakonczenia { get; set; }
        public decimal Kaucja { get; set; }
        public decimal Cena { get; set; }
        public Samochód samochód { get; set; }
    }
}
