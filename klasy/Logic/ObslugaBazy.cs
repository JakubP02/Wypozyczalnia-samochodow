using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypozyczalniaAut.Logic;
using System.IO;
using WypozyczalniaAut.Model;

namespace WypozyczalniaAut.Logic
{
    public class ObslugaBazy
    {
        static public string PlikCarList = @"..\..\..\BazaDanych\CarList.csv";
        static public string PlikUserList = @"..\..\..\BazaDanych\UserList.csv";
        static public string PlikWypozyczenia = @"..\..\..\BazaDanych\Wypozyczenia.csv";
        static public string PlikPracownik = @"..\..\..\BazaDanych\PracownikList.csv";
        public static Klient daneZalogowanegoUzytkownika;
        public static List<Klient> ListaKlientow = new List<Klient>();
        public static List<Samochód> ListaSamochodow = new List<Samochód> ();      
        public static List<Wypozyczenie> ListaWypozyczen = new List<Wypozyczenie> ();
        public static List<Pracownik> listaPracownikow = new List<Pracownik> ();
        public static Pracownik pracownik;
        public void SaveToFileUser(List<Klient> listaKlientow)
        {   


            if (File.Exists(PlikUserList))
            {
                File.Delete(PlikUserList);
            }

            using (FileStream stream = File.Create(PlikUserList))
            using (StreamWriter writer = new StreamWriter(stream))
            //using (var stream = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {

                //stream.WriteRecords(listaZamowien);

                foreach (Klient zam1 in listaKlientow)
                {

                    writer.WriteLine(zam1);
                }
            }
        }
        public void SaveToFileCarList(List<Samochód> ListaAut)
        {

            if (File.Exists(PlikCarList))
            {
                File.Delete(PlikCarList);
            }

            using (FileStream stream = File.Create(PlikCarList))
            using (StreamWriter writer = new StreamWriter(stream))
            //using (var stream = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {

                //stream.WriteRecords(listaZamowien);

                foreach (Samochód zam1 in ListaAut)
                {

                    writer.WriteLine(zam1);
                }
            }
        }
        public void SaveToFileWypozyczenia(List<Wypozyczenie> listaWypozyczen)
        {


            if (File.Exists(PlikWypozyczenia))
            {
                File.Delete(PlikWypozyczenia);
            }

            using (FileStream stream = File.Create(PlikWypozyczenia))
            using (StreamWriter writer = new StreamWriter(stream))
            //using (var stream = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {

                //stream.WriteRecords(listaZamowien);

                foreach (Wypozyczenie zam1 in listaWypozyczen)
                {

                    writer.WriteLine(zam1);
                }
            }
        }
        public void SaveToFilePracownik(List<Pracownik> listaPracownikow)
        {


                if (File.Exists(PlikPracownik))
                {
                    File.Delete(PlikPracownik);
                }

                using (FileStream stream = File.Create(PlikPracownik))
                using (StreamWriter writer = new StreamWriter(stream))
                //using (var stream = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {

                    //stream.WriteRecords(listaZamowien);

                    foreach (Pracownik zam1 in listaPracownikow)
                    {

                    writer.WriteLine(zam1);
                    }
                }
        }

        public List<Klient> ReadFromFileUser(string plik)
        {
            List<Klient> listaKlientow = new List<Klient>();

            //using (FileStream stream = File.OpenRead(nazwaPliku))
            //using (StreamReader reader = new StreamReader(stream))

            string[] plikCaly = File.ReadAllLines(plik);
            foreach (string linia in plikCaly)
            {

                string[] parser = linia.Split(',');
                int Id = Convert.ToInt16(parser[0]);
                string Imie = parser[1];
                string Nazwisko = parser[2];
                string Pesel = parser[3];
                string NrPrawaJazdy = parser[4];
                string haslo = parser[5];
                string Email = parser[6];
                string Login = parser[7];
                DateTime DataUrodzenia = Convert.ToDateTime(parser[8]);
                string Status = parser[9];
                Klient klienci = new Klient();
                switch (Status)
                {
                    case "Zablokowany":
                        klienci.statusKlienta = Model.StatusKlienta.Zablokowany;
                        break;
                    case "Aktywny":
                        klienci.statusKlienta = Model.StatusKlienta.Aktywny;
                        break;
                    case "Weryfikacja":
                        klienci.statusKlienta = Model.StatusKlienta.Weryfikacja;
                        break;
                }
                klienci.Id = Id;
                klienci.Imie = Imie;
                klienci.Nazwisko = Nazwisko;
                klienci.Email = Email;
                klienci.haslo = haslo;
                klienci.Pesel = Pesel;
                klienci.NrPrawaJazdy = NrPrawaJazdy;
                klienci.login = Login;
                klienci.DataUrodzenia = DataUrodzenia;
               
                listaKlientow.Add(klienci);
            }

            return listaKlientow;
        }

        
        public  List<Samochód> ReadFromFileCars(string plik)
        {
            List<Samochód> listaAut = new List<Samochód>();

            //using (FileStream stream = File.OpenRead(nazwaPliku))
            //using (StreamReader reader = new StreamReader(stream))

            string[] plikAuta = File.ReadAllLines( plik);
            foreach (string linia in plikAuta)
            {

                string[] parser = linia.Split(',');
                int Id = Convert.ToInt16(parser[0]);
                string Marka = parser[1];
                string Model = parser[2];
                string Typ = parser[4];
                string NrRejestracyjny = parser[3];
                decimal pojemnoscSilnika = Convert.ToDecimal(parser[5]);
                int moc = Convert.ToInt16(parser[6]);
                string garazowanie = parser[7];
                decimal KosztGodzina = Convert.ToDecimal(parser[8]);
                decimal KosztDoba = Convert.ToDecimal(parser[9]);
                Samochód Auta = new Samochód();
                switch (garazowanie)
                {
                    case "HALA1":
                        Auta.garażowanie = Garaż.HALA1;
                        break;
                    case "HALA2":
                        Auta.garażowanie = Garaż.HALA2;
                        break;
                    case "HALA3":
                        Auta.garażowanie = Garaż.HALA3;
                        break;
                    case "Wypozyczono":
                        Auta.garażowanie = Garaż.Wypozyczono;
                        break;
                }
                Auta.Id = Id;
                Auta.Marka = Marka;
                Auta.Model = Model;
                Auta.NrRejestracyjny = NrRejestracyjny;
                Auta.Typ = Typ;
                Auta.PojemnoscSilnika = pojemnoscSilnika;
                Auta.Moc = moc;
                Auta.KosztWypozyczeniaGodzina = KosztGodzina;
                Auta.KosztWypozyczeniaDoba = KosztDoba;
                listaAut.Add(Auta);
            }
            return listaAut;
        }

        public List<Wypozyczenie> ReadFromFileWypozyczenia(string plik)
        {
            List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();

            //using (FileStream stream = File.OpenRead(nazwaPliku))
            //using (StreamReader reader = new StreamReader(stream))

            string[] plikWYpo = File.ReadAllLines(plik);
            foreach (string linia in plikWYpo)
            {

                string[] parser = linia.Split(',');
                int IdAtuto = Convert.ToInt16(parser[0]);
                int   IdKlient = Convert.ToInt16(parser[1]);
                DateTime dataWYP = Convert.ToDateTime(parser[2]);
                DateTime dataODD = Convert.ToDateTime(parser[3]);
                string status = parser[4];
                decimal oplata = Convert.ToDecimal(parser[5]);


                Wypozyczenie wypo = new Wypozyczenie();
                switch (status)
                {
                    case "Zablokowany":
                        wypo.statusZamowienie = StatusKlienta.Zablokowany;
                        break;
                    case "Aktywny":
                        wypo.statusZamowienie = StatusKlienta.Aktywny;
                        break;
                    case "Weryfikacja":
                        wypo.statusZamowienie = StatusKlienta.Weryfikacja;
                        break;
                }
                wypo.IDklienta = IdKlient;
                wypo.IDpojazdu = IdAtuto;
                wypo.godzinaWypzyczenia = dataWYP;
                wypo.godzinaOddania = dataODD;
                wypo.oplata = oplata;

                wypozyczenia.Add(wypo);
            }
            return wypozyczenia;
        }

        public List<Pracownik> ReadFromFilePracownik(string plik)
        {
            List<Pracownik> pracownicy = new List<Pracownik>();

            //using (FileStream stream = File.OpenRead(nazwaPliku))
            //using (StreamReader reader = new StreamReader(stream))

            string[] plikCaly = File.ReadAllLines(plik);
            foreach (string linia in plikCaly)
            {
                Pracownik pracownik = new Pracownik();
                string[] parser = linia.Split(',');
                int Id = Convert.ToInt16(parser[0]);
                string Haslo = parser[1];
                decimal dodane = Convert.ToDecimal(parser[2]);
                
                
                pracownik.Id = Id;
                pracownik.haslo = Haslo;
                pracownik.dodanyKoszt = dodane;
           

                pracownicy.Add(pracownik);
            }

            return pracownicy;
        }

        //zapisywanie do bazy acces
        //czytanie z bazy acces 


    }
}
