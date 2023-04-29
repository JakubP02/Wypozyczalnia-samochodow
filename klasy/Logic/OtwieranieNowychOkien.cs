using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WypozyczalniaAut.Logic;
using WypozyczalniaAut.Model;



namespace WypozyczalniaAut.Logic
{
    public class OtwieranieNowychOkien
    {
        List<Klient> CzytanieZplikuKlienci = new List<Klient>();
        ObslugaBazy ObslugaBazy = new ObslugaBazy();
        public static string ObrazFlagaPolski = @"..\..\..\formatki użytkownika\pics\plflag.png";
        public static string ObrazFlagaAngli = @"..\..\..\formatki użytkownika\pics\ukflag.png";

        public bool CzyPoprawnyLogin(string Login, string Hasło, string KomunikatBlad)
        {
            bool poprawneLogowanie = false;
            bool znalezionoLogin = false;
            
            CzytanieZplikuKlienci = ObslugaBazy.ReadFromFileUser(ObslugaBazy.PlikUserList);
            foreach (Klient DaneKlienta in CzytanieZplikuKlienci)
            {
                if (DaneKlienta.login == Login)
                {       
                        znalezionoLogin=true;
                        if (DaneKlienta.haslo == Hasło)
                        {
                            
                            string statusLogującego = Convert.ToString(DaneKlienta.statusKlienta);
                        

                            switch (statusLogującego)
                            {
                            case "Aktywny":
                                ObslugaBazy.daneZalogowanegoUzytkownika = DaneKlienta;
                                poprawneLogowanie = true;
                                break;
                            case "Zablokowany":
                                System.Windows.Forms.MessageBox.Show("Twoje konto zostało zablokowane!");
                                poprawneLogowanie = false;
                                break;
                            case "Weryfikacja":
                                System.Windows.Forms.MessageBox.Show("Twoje konto jest w trakcie weryfikacji, spróbuj ponowanie później. ");
                                poprawneLogowanie = false;
                                break;

                            } 
                               
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show(KomunikatBlad + " Błędne hasło!");
                        }
                }
              
            }
            if (!znalezionoLogin)
            {
                System.Windows.Forms.MessageBox.Show(KomunikatBlad + " Błędny Login");
            }
            return poprawneLogowanie;
        }
        public bool PowrotPoZmianieHasła(string StareHasło, string NoweHasło, string NoweHasłoPowtórzone)
        {
            int I =  0; // numer pozycji zmieniającego hasło  kolejne iteracje
            int k = 0; //indeks zmieniający
            bool  poprawnaZamiana = true;
            CzytanieZplikuKlienci = ObslugaBazy.ReadFromFileUser(ObslugaBazy.PlikUserList);
           
                if (StareHasło == ObslugaBazy.daneZalogowanegoUzytkownika.haslo)
                {
                    if (NoweHasło.Length > 7 && NoweHasło.Length < 21)
                    {
                        foreach (Klient klient in CzytanieZplikuKlienci)
                        {
                            if (klient.login == ObslugaBazy.daneZalogowanegoUzytkownika.login && klient.haslo == ObslugaBazy.daneZalogowanegoUzytkownika.haslo)
                            {
                                k = I;
                            }
                            I++;
                        }
                        if (NoweHasło == NoweHasłoPowtórzone)
                        {
                            CzytanieZplikuKlienci[k].haslo = NoweHasło;
                            ObslugaBazy.daneZalogowanegoUzytkownika.haslo = NoweHasło;

                            System.Windows.Forms.MessageBox.Show("Hasło zostało zmienione dla użytkownika " + ObslugaBazy.daneZalogowanegoUzytkownika.Imie.ToString() + "  " + ObslugaBazy.daneZalogowanegoUzytkownika.Nazwisko.ToString());
                            poprawnaZamiana = true;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Nowe hasło zostało błednie potwierdzone");
                            poprawnaZamiana = false;

                        }
                    }
                    else
                    {
                        poprawnaZamiana = false;
                        System.Windows.Forms.MessageBox.Show("Hasło powinno mnieć miedzy 8 a 20 znaków");
                    }

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Podane hasło nie jest zgodne z twoim aktualnym hasłem");
                    poprawnaZamiana = false;
                }

                if (poprawnaZamiana)
                {
                    ObslugaBazy.SaveToFileUser(CzytanieZplikuKlienci);
                }
            
         

            return poprawnaZamiana;
         
        }
        

        public bool TworzenieNowegoPrfilu(Klient nowyKlient, string PlikZUzytkownikami,string powtorzoneHaslo, bool ZaakceptowanoRegulamin, ref string komunikat)
        {

            bool wynikOperacji = true;
            DateTime NajmniejszyMozliwyWiek = DateTime.Now.AddYears(-18);

            CzytanieZplikuKlienci = ObslugaBazy.ReadFromFileUser(PlikZUzytkownikami);
            int MaxID = nowyKlient.Id;
            foreach (Klient zarejestrowanyKlient in CzytanieZplikuKlienci)
            {
                if (zarejestrowanyKlient.Id > MaxID)
                {
                    MaxID = zarejestrowanyKlient.Id;
                }
              


            }


            // komunuikat =   ; 

            int NoweIdKlienta = MaxID + 1;
            nowyKlient.Id = NoweIdKlienta;
            nowyKlient.statusKlienta = StatusKlienta.Weryfikacja;
            // najpierw sprawdzamy dane, czy są poprawne, zeby na prozno nie przesziwać bazy w celu znalezenia powtórzeń

            if (nowyKlient.Imie.Length < 3)
            {
                komunikat = "W polu imie wprowadź conajmniej 3 znaki!";
               
                wynikOperacji = false;
            }
            else if (nowyKlient.Imie.Length > 15)
            {
                komunikat = "Podane Imie jest zbyt długie, postaraj sie zapisać 15 pierwszych znaków twojego imienia" ;
                wynikOperacji = false;
            }
            else if (nowyKlient.Nazwisko.Length < 3)
            {
                komunikat = "W polu nazwisko wprowadź conajmniej 3 znaki!";
                wynikOperacji = false;
            }
            else if (nowyKlient.Nazwisko.Length > 20)
            {
                komunikat = "Podane Nazwisko jest zbyt długie, postaraj sie zapisać 20 pierwszych znaków twojego nazwiska"; 
                wynikOperacji = false;
            }
            else if (nowyKlient.DataUrodzenia > NajmniejszyMozliwyWiek)
            {
                komunikat = "Niestety osoby niepełnoletnie nie mogą korzystać z aplikacji"; 
                wynikOperacji = false;

            }
            else if (Regex.IsMatch(nowyKlient.Email, @"^[^@]{1,}@[^@]{1,}$") == false)
            {
                komunikat = "Podany adres e mail jest błedny, musi zawierać jeden znak  małpy - @ oraz tekst przed i za znakiem. ";
                wynikOperacji = false;
            }
            else if (nowyKlient.Pesel.Length != 11)
            {
                komunikat = "Długość numeru pesel nie jest poprawna, potrzeba jedenaście cyfr";
                wynikOperacji = false;
            }
            else if (nowyKlient.Pesel.All(Char.IsDigit) == false)
            {
                komunikat = "Twój numer pesel zawiera inne znaki niż cyfry ";
                wynikOperacji = false;
            }
            else if (Regex.IsMatch(nowyKlient.NrPrawaJazdy, "^[a-zA-Z][0-9]{7}$") == false)
            {
                komunikat = "Błędny format numeru prawa jazdy. Pierwszy znak to lietera, a kolejne 7 to cyfry. ";
                wynikOperacji = false;
            }
            else if (nowyKlient.login.Length < 8 || nowyKlient.login.Length > 20)
            {
                komunikat = "Login posiada złą długość. Podaj login, który ma pomiędzy 8 a 20 znaków ";
                wynikOperacji = false;
            }
            else if (nowyKlient.haslo.Length < 8 || nowyKlient.haslo.Length > 20)
            {
                komunikat ="Hasło posiada złą długość. Podaj hasło, które ma pomiędzy 8 a 20 znaków ";
                wynikOperacji = false;
            }
            else if (nowyKlient.haslo != powtorzoneHaslo)
            {
                komunikat = "Niepoprawnie powtórzone hasło"; ;
                wynikOperacji = false;
            }
            if (wynikOperacji)
                {
                    foreach (Klient starzyKlienci in CzytanieZplikuKlienci)
                    {
                        if (starzyKlienci.Pesel == nowyKlient.Pesel)
                        {
                            komunikat = "W naszej bazie istnieje już osoba o tym numerze pesel. Spróbuj przejsc do logowania.";
                            wynikOperacji = false;
                            break;                        
                        }
                        if (starzyKlienci.NrPrawaJazdy == nowyKlient.NrPrawaJazdy)
                        {
                            komunikat ="Podany numer prawajazdy jest już przypisany do konta w naszym systemie! Nie możemy dokonać rejestracji.";
                            wynikOperacji = false;
                            break;
                    }
                        if (starzyKlienci.login == nowyKlient.login)
                        {
                            komunikat = "Ten login jest już zarezewowany dla kogoś innego. Spróbuj ponownie.";
                            wynikOperacji = false;
                            break; 
                        }
                    }
                }
            if (ZaakceptowanoRegulamin == false && wynikOperacji)
            {
                komunikat ="Twoje dane są poprawne. Pamiętaj jednak, że zaakceptowanie Regulaminu jest wymagane do stworzenia nowego konta";
                wynikOperacji = false;

            }
            //dodwanie klienta do kolekcji
            if (wynikOperacji)
            {
                CzytanieZplikuKlienci.Add(nowyKlient);
                ObslugaBazy.SaveToFileUser(CzytanieZplikuKlienci);
            }

            return wynikOperacji;
        }

        public List< string> mapaPojazdow(List<Samochód> ListaSamochodow)
        {
            List<string> StanGaraży = new List<string>();
            List<string> H1 = new List<string>();
            List<string> H2 = new List<string>();
            List<string> H3 = new List<string>();
            List<string> W = new List<string>();
            int[] Ilosc = new int[4] { 0, 0, 0, 0 }; ;
            foreach (Samochód auto in ListaSamochodow)
            {
                if (Garaż.HALA1 == auto.garażowanie)
                {
                    Ilosc[0] += 1;
                    H1.Add(Garaż.HALA1.ToString() + ": " + auto.Marka + "  " + auto.Model + "  " + auto.NrRejestracyjny);
                }
                if (Garaż.HALA2 == auto.garażowanie)
                {
                    Ilosc[1] += 1;
                    H2.Add(Garaż.HALA2.ToString() + ": " + auto.Marka + "  " + auto.Model + "  " + auto.NrRejestracyjny);
                }
                if (Garaż.HALA3 == auto.garażowanie)
                {
                    Ilosc[2] += 1;
                    H3.Add(Garaż.HALA3.ToString() + ": " + auto.Marka + "  " + auto.Model + "  " + auto.NrRejestracyjny);

                }
                if (Garaż.Wypozyczono == auto.garażowanie)
                {
                    Ilosc[3] += 1;
                    W.Add(Garaż.Wypozyczono.ToString() + ": " + auto.Marka + "  " + auto.Model + "  " + auto.NrRejestracyjny);
                }

            }
            StanGaraży.Add(Garaż.HALA1.ToString() + ":  " + Ilosc[0].ToString() + "/" + ((int)Garaż.HALA1).ToString());
            StanGaraży.Add(Garaż.HALA2.ToString() + ":  " + Ilosc[1].ToString() + "/" + ((int)Garaż.HALA2).ToString());
            StanGaraży.Add(Garaż.HALA3.ToString() + ":  " + Ilosc[2].ToString() + "/" + ((int)Garaż.HALA3).ToString());
            StanGaraży.Add(Garaż.Wypozyczono.ToString() + ":  " + Ilosc[3].ToString());
            foreach (string pojazd1 in H1)
            {
                StanGaraży.Add(pojazd1);
            }
            foreach(string pojazd2 in H2)
            {
                StanGaraży.Add(pojazd2);
            }
            foreach(string pojazd3 in H3)
            {
                StanGaraży.Add(pojazd3);
            }
            foreach(string pojazd4 in W)
            {
                StanGaraży.Add(pojazd4);
            }





            return StanGaraży;
            
        }

        public int AutoWypozyczajacego(int IDKLIENTA)
        {
            int IdAuto = 0;
          
            List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();
            wypozyczenia = ObslugaBazy.ListaWypozyczen;
            
            foreach (Wypozyczenie wypo in wypozyczenia)
            {
                if (wypo.statusZamowienie == StatusKlienta.Aktywny && wypo.IDklienta == IDKLIENTA)
                {
                    IdAuto = wypo.IDpojazdu;


                }         
            }
            return IdAuto;
        }

        public bool WeryfikacjaHaslaPracownika(int Id, string haslo, ref string komunikat)

        {
            bool wer = false;
            {
                foreach (Pracownik p in ObslugaBazy.listaPracownikow)
                {
                    if (p.Id == Id)
                    {
                        if (p.haslo == haslo)
                        {
                            wer = true;
                            komunikat = " Poprawnie zalogowano ";
                        }
                        else
                        {
                            komunikat = "Błedne haslo, dla pracownika nr. " + p.Id + "wpisz " + p.haslo;
                        }
                        
                    }
                }


            }
            return wer;


        }
    }
}

