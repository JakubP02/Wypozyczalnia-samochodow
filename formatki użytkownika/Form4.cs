using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WypozyczalniaAut.Model;
using WypozyczalniaAut.Logic;
using WypozyczalniaAut;

namespace WypozyczalniaSamochodow
{
    public partial class Form4 : Form
    {
        
        //ObslugaBazyPojazdow.ReadFromFileCars(ObslugaBazyPojazdow.PlikCarList)
        public Form4(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk4.Tag = jezyk.ToString();
        }

        private bool GetUnderline()
        {
            return listBoxFrom4.Font.Underline;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
  

            ObslugaBazy ObslugaBazyPojazdow = new ObslugaBazy();
            ObslugaBazy.ListaSamochodow = ObslugaBazyPojazdow.ReadFromFileCars(ObslugaBazy.PlikCarList);
            ParametryFiltracji parametry = new WypozyczalniaAut.Model.ParametryFiltracji();
            ObslugaBazy.ListaWypozyczen = ObslugaBazyPojazdow.ReadFromFileWypozyczenia(ObslugaBazy.PlikWypozyczenia);


            List<WypozyczalniaAut.Samochód> filteredList = Filtracja.Filter(Filtracja.parametryFiltrowania, ObslugaBazy.ListaSamochodow);
            listBoxFrom4.Items.Clear();
           
            List<int> indeksyListyWypozyczono = new List<int>();
            foreach (WypozyczalniaAut.Samochód Pojazdy in filteredList)
            {
                listBoxFrom4.Items.Add(Pojazdy.Marka + Pojazdy.Model + " Doba/Day: " + Pojazdy.KosztWypozyczeniaDoba + " zł " + " Godzina/Hour: " + Pojazdy.KosztWypozyczeniaGodzina + " zł " + "   Nr: "  + Pojazdy.NrRejestracyjny );
            }
            
 
            try
            {
                if (buttonRejestracjaZmianaJezyk4.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk4.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    buttonMenuFiltruj4.Text = "FILTRUJ";
                    buttonMenuListaPojazdow4.Text = "LISTA \n" +
                        "POJAZDÓW";
                    buttonMenuMojeWypozyczenia4.Text = "MOJE WYPOŻYCZENIA";
                    buttonMenuPodejrzyjDane4.Text = "ZOBACZ OFERTĘ";
                    buttonMenuPojazdyNaMapie4.Text = "POJAZDY \n" +
                        "NA MAPIE";
                    buttonMenuUstawienia4.Text = "USTAWIENIA";
                    buttonMenuWyloguj4.Text = "WYLOGUJ";
                    buttonMenuWypozycz4.Text = "WYPOŻYCZ";
                    buttonProfilUzytkownika4.Text = "P \n" +
                        "R \n"+
                        "O \n" +
                        "F \n" +
                        "I \n" +
                        "L";                
                }
                else
                {
                    buttonRejestracjaZmianaJezyk4.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    buttonMenuFiltruj4.Text = "FILTER";
                    buttonMenuListaPojazdow4.Text = "LIST OF \n" +
                        "VEHICLES";
                    buttonMenuMojeWypozyczenia4.Text = "MY RENTALS";
                    buttonMenuPodejrzyjDane4.Text = "CHECK \n" +
                        "THE OFFER";
                    buttonMenuPojazdyNaMapie4.Text = "VEHICLES ON \n" +
                        "THE MAP";
                    buttonMenuUstawienia4.Text = "SETTINGS";
                    buttonMenuWyloguj4.Text = "LOG OUT";
                    buttonMenuWypozycz4.Text = "RENTAL";
                    buttonProfilUzytkownika4.Text = "P \n" +
                        "R \n" +
                        "O \n" +
                        "F \n" +
                        "I \n" +
                        "L \n" + 
                        "E";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenuWyloguj4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Wylogowano!");
                Form1 form1 = new Form1("Ang");  
                Hide();
                form1.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProfilUzytkownika4_Click(object sender, EventArgs e)
        {
            try
            {
                Form8 FromUstawienia = new Form8(buttonRejestracjaZmianaJezyk4.Tag.ToString());
                Hide();
                FromUstawienia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRejestracjaZmianaJezyk4_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk4.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk4.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk4.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    buttonMenuFiltruj4.Text = "FILTER";
                    buttonMenuListaPojazdow4.Text = "LIST OF \n" +
                        "VEHICLES";
                    buttonMenuMojeWypozyczenia4.Text = "MY RENTALS";
                    buttonMenuPodejrzyjDane4.Text = "CHECK \n" +
                        "THE OFFER";
                    buttonMenuPojazdyNaMapie4.Text = "VEHICLES ON \n" +
                        "THE MAP";
                    buttonMenuUstawienia4.Text = "SETTINGS";
                    buttonMenuWyloguj4.Text = "LOG OUT";
                    buttonMenuWypozycz4.Text = "RENTAL";
                    buttonProfilUzytkownika4.Text = "P \n" +
                        "R \n" +
                        "O \n" +
                        "F \n" +
                        "I \n" +
                        "L \n" +
                        "E";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk4.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk4.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    buttonMenuFiltruj4.Text = "FILTRUJ";
                    buttonMenuListaPojazdow4.Text = "LISTA \n" +
                        "POJAZDÓW";
                    buttonMenuMojeWypozyczenia4.Text = "MOJE WYPOŻYCZENIA";
                    buttonMenuPodejrzyjDane4.Text = "ZOBACZ OFERTĘ";
                    buttonMenuPojazdyNaMapie4.Text = "POJAZDY \n" +
                        "NA MAPIE";
                    buttonMenuUstawienia4.Text = "USTAWIENIA";
                    buttonMenuWyloguj4.Text = "WYLOGUJ";
                    buttonMenuWypozycz4.Text = "WYPOŻYCZ";
                    buttonProfilUzytkownika4.Text = "P \n" +
                        "R \n" +
                        "O \n" +
                        "F \n" +
                        "I \n" +
                        "L";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenuListaPojazdow4_Click(object sender, EventArgs e)
        {
            try
            {
                Filtracja.parametryFiltrowania.Marka = "";
                Filtracja.parametryFiltrowania.Model = "";
                Filtracja.parametryFiltrowania.garaż = "";
                Filtracja.parametryFiltrowania.Pojemnosc = 0;

                List<WypozyczalniaAut.Samochód> filteredList = Filtracja.Filter(Filtracja.parametryFiltrowania, ObslugaBazy.ListaSamochodow);
                listBoxFrom4.Items.Clear();
                foreach (WypozyczalniaAut.Samochód Pojazdy in filteredList)
                {
                    listBoxFrom4.Items.Add(Pojazdy.Marka + Pojazdy.Model + " Doba/Day: " + Pojazdy.KosztWypozyczeniaDoba + " zł " + " Godzina/Hour: " + Pojazdy.KosztWypozyczeniaGodzina + " zł " + "   Nr: " + Pojazdy.NrRejestracyjny);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenuPojazdyNaMapie4_Click(object sender, EventArgs e)
        {
            OtwieranieNowychOkien otwieranieNowychOkienEdychjaIstniejacego = new OtwieranieNowychOkien();
            try
            {
                listBox2Form4.Items.Clear();
                foreach (string Pojazdy in otwieranieNowychOkienEdychjaIstniejacego.mapaPojazdow(ObslugaBazy.ListaSamochodow))
                {
                    listBox2Form4.Items.Add(Pojazdy);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenuFiltruj4_Click(object sender, EventArgs e)
        {
            try
            {
                Form5 Filtry = new Form5(buttonRejestracjaZmianaJezyk4.Tag.ToString());
                Hide();
                Filtry.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenuWypozycz4_Click(object sender, EventArgs e)
        {
            try
            {
                ZarzadzeniePojazdami noweWypo = new ZarzadzeniePojazdami();
                Samochód pojazdWypozyczany = new Samochód();
                if (listBoxFrom4.SelectedIndex != -1) // znajdowanie wybranego pojazdu
                {
                    string daneAuta = listBoxFrom4.SelectedItem.ToString();
                    int indeksOstatniejSpacji = daneAuta.LastIndexOf(" ");
                    string NrRejestracyjny = daneAuta.Substring(indeksOstatniejSpacji + 1);
                    int IdKlienta = ObslugaBazy.daneZalogowanegoUzytkownika.Id;
                    pojazdWypozyczany = noweWypo.WybraneAuto(ObslugaBazy.ListaSamochodow, NrRejestracyjny);
                    int IdAuta = pojazdWypozyczany.Id;

                    if (pojazdWypozyczany.garażowanie != Garaż.Wypozyczono)
                    {   // generujemy list wypozyczen
                        

                        ZarzadzanieWypozyczeniami wopozyczenie = new ZarzadzanieWypozyczeniami();
                   
                        if (wopozyczenie.SprawdzCzyWYpozycza(ObslugaBazy.ListaWypozyczen, IdKlienta) != true)
                        {
                            wopozyczenie.DodajWypozyczenie(IdKlienta, IdAuta);
                            string status = "Wypozyczono";
                            noweWypo.ZmianaStatusuPojazdu(IdAuta, status);
                            Hide();
                            Form10 ListaMoichWypozyczen = new Form10("Ang"); // zmienic tekst
                            ListaMoichWypozyczen.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Drogi użytkowniku, wypozyczasz pojazd!!");
                        
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wybierz Pojazd, który jest w HALI");
                    }

                }
                else
                {
                    MessageBox.Show("Wybierz Pojazd");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenuPodejrzyjDane4_Click(object sender, EventArgs e)
        {
            try
            { 
                if(listBoxFrom4.SelectedIndex !=-1)
                        {
                    string daneAuta = listBoxFrom4.SelectedItem.ToString();
                    int indeksOstatniejSpacji = daneAuta.LastIndexOf(" ");
                    string NrRejestracyjny = daneAuta.Substring(indeksOstatniejSpacji + 1);
                    foreach (Samochód samochod in ObslugaBazy.ListaSamochodow)
                    {
                        // dodać ifa który zrobi inna wersje dla angielkiego 
                        if (samochod.NrRejestracyjny == NrRejestracyjny)
                        {
                            MessageBox.Show("Dane pojazdu \n Id: " + samochod.Id.ToString() + " \n Marka: " + samochod.Marka + "\n Model" + samochod.Model
                                + "\n NrRejestracyjny  " + samochod.NrRejestracyjny + " \n Typ " + samochod.Typ + "\n Pojemnosc " + samochod.PojemnoscSilnika + "\n Moc" + samochod.Moc
                                + "\n Garażowanie: " + samochod.garażowanie.ToString() + "\n KosztGodzina" + samochod.KosztWypozyczeniaGodzina + "\n KosztDoba:" + samochod.KosztWypozyczeniaDoba);

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonMenuMojeWypozyczenia4_Click(object sender, EventArgs e)
        {
            try
            {
                Form10 MojeWypozyczenia = new Form10(buttonRejestracjaZmianaJezyk4.Tag.ToString());
                Hide();
                MojeWypozyczenia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listBoxFrom4_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBoxFrom4.Items[e.Index].ToString().Contains("Wypozyczono"))
            {
                e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
                e.Graphics.DrawString(listBoxFrom4.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBoxFrom4.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        private void listBoxFrom4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
