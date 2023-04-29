using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaAut.Model;
using WypozyczalniaAut.Logic;

namespace WypozyczalniaAut
{
    public class Klient
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public string NrPrawaJazdy { get; set; }
        public string haslo { get; set; }
       
        public string Email { get; set; }
        public string login { get; set; }
        
        public DateTime DataUrodzenia { get; set; }

        public StatusKlienta statusKlienta { get; set; }
        public override string ToString()
        {
            return Id.ToString()+","+Imie + "," +Nazwisko + "," +Pesel  +"," + NrPrawaJazdy + "," + haslo + "," +Email + "," +login + "," +DataUrodzenia.ToString() + "," + statusKlienta.ToString();
        }

    }
}
