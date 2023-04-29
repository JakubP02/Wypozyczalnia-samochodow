using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaAut.Model;

namespace WypozyczalniaAut.Logic
{
    public class ZarzadanieFinansami
    {
        public void AktualizacjaKosztówPracownika(int id, decimal koszt)
        {
            List<Pracownik> listapracownikow = new List<Pracownik>();
            ObslugaBazy obslugaBazy = new ObslugaBazy();
            int i = 0;
            listapracownikow = obslugaBazy.ReadFromFilePracownik(ObslugaBazy.PlikPracownik);
            foreach (Pracownik p in listapracownikow)
            {
                if (p.Id == id)
                {
                    listapracownikow[i].dodanyKoszt += koszt;
                }
                i++;
            }
            ObslugaBazy.listaPracownikow = listapracownikow;
            obslugaBazy.SaveToFilePracownik(listapracownikow);
        }
        public decimal Straty()
        {
            decimal straty = 0;
            List<Pracownik> pracownicy = new List<Pracownik>();
            ObslugaBazy obsluga = new ObslugaBazy();
            pracownicy = obsluga.ReadFromFilePracownik(ObslugaBazy.PlikPracownik);
            foreach (Pracownik prac in pracownicy)
            {
                straty += prac.dodanyKoszt;
            }
            return straty;
        }

        public decimal Zyski()
        {
            decimal zyskLaczny = 0;
            List<Wypozyczenie> wypozyczenia =  new List<Wypozyczenie>();
            ObslugaBazy obsluga = new ObslugaBazy();
            wypozyczenia = obsluga.ReadFromFileWypozyczenia(ObslugaBazy.PlikWypozyczenia);
            foreach(Wypozyczenie wypo in wypozyczenia)
            {
                zyskLaczny += wypo.oplata;
            }
            return zyskLaczny;
        }

        public decimal Bilans(decimal zyski, decimal starty)
        {
            decimal wynik =  0;
            wynik = zyski - starty;
            return wynik;
        }
    }
}
