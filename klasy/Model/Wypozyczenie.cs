using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaAut.Model
{
    public class Wypozyczenie
    {
        public int IDpojazdu { get; set; }
        public int IDklienta { get; set; }
        public DateTime godzinaWypzyczenia { get; set; }
        public DateTime godzinaOddania { get; set; }
        public StatusKlienta statusZamowienie { get; set; }

        public decimal oplata { get; set; }

        public override string ToString()
        {
            return IDpojazdu.ToString()+"," + IDklienta.ToString()+"," + godzinaWypzyczenia.ToString()+"," + godzinaOddania.ToString()+"," + statusZamowienie.ToString()+"," + oplata.ToString();
        }
    }
}
