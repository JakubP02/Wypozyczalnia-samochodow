using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WypozyczalniaAut;
using WypozyczalniaAut.Logic;
using WypozyczalniaAut.Model;

namespace WypozyczalniaSamochodow
{
    public partial class Form10 : Form
    {
        public Form10(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk10.Tag = jezyk;
        }
        private void Form10_Load(object sender, EventArgs e)
        {
            string komunikatBrakuWypozyczenia = "Nie wypozyczyles pojazdu";
            try
            {
                int IDpojazduWypo;
                OtwieranieNowychOkien szukanieWypozyczonegoWBazie = new OtwieranieNowychOkien();
                
                IDpojazduWypo = szukanieWypozyczonegoWBazie.AutoWypozyczajacego(ObslugaBazy.daneZalogowanegoUzytkownika.Id);
                if (IDpojazduWypo != 0)
                {
                    List<Samochód> pojazdyWBazie = new List<Samochód>();
                    pojazdyWBazie = ObslugaBazy.ListaSamochodow;

                    foreach (Samochód pojazd in pojazdyWBazie)
                    {
                        if (pojazd.Id == IDpojazduWypo)
                        {
                            labelWYPOZYCZAM.Text = pojazd.Id.ToString() + "  " + pojazd.Marka + "   " + pojazd.Model + "  " + pojazd.NrRejestracyjny;
                        }

                    }
                }
                else {
                    labelWYPOZYCZAM.Text = komunikatBrakuWypozyczenia;
                
                }
                

                comboBoxHala.Items.Add("HALA1");
                comboBoxHala.Items.Add("HALA2");
                comboBoxHala.Items.Add("HALA3");
                if (buttonRejestracjaZmianaJezyk10.Tag.ToString() == "Ang")
                { 
                    buttonRejestracjaZmianaJezyk10.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli); ;
                    labelMojeWypozyczenia10.Text = "MOJE WYPOŻYCZENIA";
                    labelStatus10.Text = "STATUS AKTUALNEGO WYPOŻYCZENIA";
                    buttonOddajSamochod10.Text = "ODDAJE SAMOCHÓD";
                    buttonPowrot10.Text = "POWRÓT";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk10.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelMojeWypozyczenia10.Text = "MY RENTALS";
                    labelStatus10.Text = "CURRENT RENT STATUS";
                    buttonOddajSamochod10.Text = "GIVES UP THE CAR";
                    buttonPowrot10.Text = "RETURN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRejestracjaZmianaJezyk10_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk10.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk10.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk10.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelMojeWypozyczenia10.Text = "MY RENTALS";
                    labelStatus10.Text = "CURRENT RENT STATUS";
                    buttonOddajSamochod10.Text = "GIVES UP THE CAR";
                    buttonPowrot10.Text = "RETURN";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk10.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk10.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli); 
                    labelMojeWypozyczenia10.Text = "MOJE WYPOŻYCZENIA";
                    labelStatus10.Text = "STATUS AKTUALNEGO WYPOŻYCZENIA";
                    buttonOddajSamochod10.Text = "ODDAJE SAMOCHÓD";
                    buttonPowrot10.Text = "POWRÓT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOddajSamochod10_Click(object sender, EventArgs e)
        {
            int IDpojazduWypo;
            OtwieranieNowychOkien szukanieWypozyczonegoWBazie = new OtwieranieNowychOkien();
            ZarzadzeniePojazdami BazaOddane = new ZarzadzeniePojazdami();
            IDpojazduWypo = szukanieWypozyczonegoWBazie.AutoWypozyczajacego(ObslugaBazy.daneZalogowanegoUzytkownika.Id);

            ZarzadzanieWypozyczeniami oddanie = new ZarzadzanieWypozyczeniami();
            if ("Nie wypozyczyles pojazdu" != labelWYPOZYCZAM.Text)
            {
                if (comboBoxHala.SelectedIndex != -1)
                {
                    int IdOddajacego = ObslugaBazy.daneZalogowanegoUzytkownika.Id;
                    string hala = comboBoxHala.SelectedItem.ToString();
                    MessageBox.Show("Oddajesz pojazd do: " + hala);
                  
                    
             
                    string kwota = oddanie.OddajPojazd(IdOddajacego, IDpojazduWypo);//tuuuuuu
                    kwota = Regex.Replace(kwota, @"(\,\d{2})\d+", "$1");
                    BazaOddane.ZmianaStatusuPojazdu(IDpojazduWypo, hala);
                    MessageBox.Show("Twoja kwota do zaplaty to: " + kwota + " zł");
                    labelWYPOZYCZAM.Text = "Nie wypozyczyles pojazdu";
                }
                else
                {
                    MessageBox.Show("Wybierz hale");
                }
            }
            else
            {
                MessageBox.Show("Aktualnie nie wypozyczasz nic!");
            }
        }

        private void buttonPowrot10_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4("Ang");//poprawić
            Hide();
            form4.ShowDialog();
            
        }
    }
}
