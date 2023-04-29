using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaAut.Model;

namespace WypozyczalniaAut.Logic
{
    public class ZarzadzanieKlientami
    {
        public void ZmianaStatusuKlienta(int Id, string statusNowy)
        {
            StatusKlienta statusnowonadany = StatusKlienta.Aktywny;
            switch (statusNowy)
            {
                case "Zablokowany":
                    statusnowonadany = StatusKlienta.Zablokowany;
                    break;
                case "Aktywny":
                    statusnowonadany = StatusKlienta.Aktywny;
                    break;
                case "Weryfikacja":
                    statusnowonadany = StatusKlienta.Weryfikacja;
                    break;
            }
            List<Klient> klienci = new List<Klient>();
            ObslugaBazy obslugaBazy = new ObslugaBazy();
            int i = 0;
            klienci = obslugaBazy.ReadFromFileUser(ObslugaBazy.PlikUserList);
            foreach (Klient k in klienci)
            {
                if (k.Id == Id)
                {
                    klienci[i].statusKlienta = statusnowonadany;
                }
                i++;
            }

            ObslugaBazy.ListaKlientow = klienci;
            obslugaBazy.SaveToFileUser(klienci);
        }
    }
}
