using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaAut
{
    //pracownik i user powinni miec czesc dziedziczona 
    public class Pracownik
    {
        public int Id { get; set; }
        public string haslo { get; set; }
        public decimal dodanyKoszt { get; set; }

        public override string ToString()
        {
            return Id.ToString() + "," + haslo + "," + dodanyKoszt.ToString();
        }
    }
}
