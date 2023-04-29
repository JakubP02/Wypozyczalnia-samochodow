using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaAut;
using WypozyczalniaAut.Model;

namespace WypozyczalniaAut.Logic
{
    public class ZarzadzanieWypozyczeniami
    {
        public void DodajWypozyczenie(int IdK, int IdA)
        {
            Wypozyczenie wypozyczenie = new Wypozyczenie();
            ObslugaBazy obslugaWypozyczen = new ObslugaBazy();
            List<Wypozyczenie> wypozyczeniaBaza = new List<Wypozyczenie>();
            wypozyczenie.IDpojazdu = IdA;
            wypozyczenie.IDklienta = IdK;
            wypozyczenie.statusZamowienie = StatusKlienta.Aktywny;
            wypozyczenie.godzinaWypzyczenia = DateTime.Now;
            wypozyczenie.godzinaOddania = DateTime.Now;
            wypozyczenie.oplata = 0;
            wypozyczeniaBaza = obslugaWypozyczen.ReadFromFileWypozyczenia(ObslugaBazy.PlikWypozyczenia);
            wypozyczeniaBaza.Add(wypozyczenie);
            obslugaWypozyczen.SaveToFileWypozyczenia(wypozyczeniaBaza);
            ObslugaBazy.ListaWypozyczen = obslugaWypozyczen.ReadFromFileWypozyczenia(ObslugaBazy.PlikWypozyczenia);

        }

        public string OddajPojazd(int IdKlienta, int IdPojazdu)
        {
            ObslugaBazy obslugaoddawania = new ObslugaBazy();
            Wypozyczenie oddawanay = new Wypozyczenie();
            List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();
            wypozyczenia = ObslugaBazy.ListaWypozyczen;
            List<Samochód> listapojazdow = ObslugaBazy.ListaSamochodow;
            decimal  Dniowa = 0;
            decimal Godzinowa = 0;
            foreach (Samochód samochod in listapojazdow)
            { 
                if(samochod.Id == IdPojazdu)
                {
                    Dniowa = samochod.KosztWypozyczeniaDoba;
                    Godzinowa = samochod.KosztWypozyczeniaGodzina;

                }
            }

            // algorytm liczenia oplaty
            int i = 0;
            decimal oplata = 0;
            DateTime Hwypo;
            DateTime Hodd;
            foreach (Wypozyczenie wypo in wypozyczenia)
            {
                if (IdKlienta == wypo.IDklienta)
                {
                    Hwypo = wypo.godzinaWypzyczenia;
                    Hodd = DateTime.Now;
                    if ((Hodd - Hwypo).TotalHours < 24)
                    {
                        oplata = ((Convert.ToDecimal((Hodd - Hwypo).TotalHours) + 1 ) *  Godzinowa);
                    }
                    else
                    {
                        oplata = ((Convert.ToDecimal((Hodd - Hwypo).TotalHours) + 1) * Dniowa);
                    }
                    wypozyczenia[i].godzinaOddania = Hodd;
                    wypozyczenia[i].oplata = oplata;
                    wypozyczenia[i].statusZamowienie = StatusKlienta.Zablokowany;
                }
                i++;
            }
            obslugaoddawania.SaveToFileWypozyczenia(wypozyczenia);
            return oplata.ToString();
        }

        public bool SprawdzCzyWYpozycza(List<Wypozyczenie> listaWypozyczen, int IDklienta)
        {
            bool wypozycza = false;
            List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();
            wypozyczenia = listaWypozyczen;

            foreach (Wypozyczenie wypo in wypozyczenia)
            {
                if (IDklienta == wypo.IDklienta && StatusKlienta.Aktywny == wypo.statusZamowienie)
                {
                    wypozycza = true;

                }
            
                
            }
            return wypozycza;

            
        }
    }
}
