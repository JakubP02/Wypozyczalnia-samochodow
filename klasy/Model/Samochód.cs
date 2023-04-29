using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaAut.Logic;

namespace WypozyczalniaAut
{
    public class Samochód
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string NrRejestracyjny { get; set; }
        public string Typ { get; set; }
        public decimal PojemnoscSilnika { get; set; }
        public int Moc { get; set; }
        public Garaż garażowanie { get; set; }
        public decimal KosztWypozyczeniaGodzina { get; set; }
        public decimal KosztWypozyczeniaDoba { get; set; }

        public override string ToString()
        {
            return Id.ToString() + "," + Marka + "," + Model + "," + NrRejestracyjny + "," + Typ + "," + PojemnoscSilnika.ToString() + "," + Moc.ToString() + "," + garażowanie.ToString() + "," + KosztWypozyczeniaGodzina.ToString() + "," + KosztWypozyczeniaDoba.ToString();
        }
    }
}
