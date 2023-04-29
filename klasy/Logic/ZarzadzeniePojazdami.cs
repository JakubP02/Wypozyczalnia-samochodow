using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaAut.Model;

namespace WypozyczalniaAut.Logic
{
    public class ZarzadzeniePojazdami
    {
        
        public Samochód WybraneAuto(List<Samochód> ListaPojazdow, string NRrejestrcyjny) // funkcje dodajemy przy zabezpieczeniu wczesniej ze indeks nie jest z poza 
        {
            Samochód wybrany = new Samochód();

            foreach (Samochód auto in ListaPojazdow)
            {
                if (NRrejestrcyjny== auto.NrRejestracyjny)
                {
                    wybrany = auto;
                }
            }
            return wybrany; 
        }
        public void ZmianaStatusuPojazdu(int IDPojazdu, string StatusWypozyczenia)
        {
            Garaż statusNowy = Garaż.Wypozyczono;
            switch (StatusWypozyczenia)
            {
                case "HALA1":
                    statusNowy = Garaż.HALA1;
                    break;
                case "HALA2":
                    statusNowy = Garaż.HALA2;
                    break;
                case "HALA3":
                    statusNowy = Garaż.HALA3;
                    break;
                case "Wypozyczono":
                    statusNowy = Garaż.Wypozyczono;
                    break;
            }
            ObslugaBazy obslugaPojazdow = new ObslugaBazy();
            int i = 0;
            List<Samochód> pojazdy = new List<Samochód>();
            pojazdy = ObslugaBazy.ListaSamochodow;
            foreach (Samochód auto in pojazdy)
            {
                if (auto.Id == IDPojazdu)
                {
                    pojazdy[i].garażowanie = statusNowy;
                }
                i++;
            }
            obslugaPojazdow.SaveToFileCarList(pojazdy);


        }
    }
}
