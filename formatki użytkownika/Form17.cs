using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WypozyczalniaAut.Logic;

namespace WypozyczalniaSamochodow
{
    public partial class Form17 : Form
    {
        public Form17(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk17.Tag = jezyk;
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk17.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk17.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelBagaznik17.Text = "BAGAŻNIK";
                    labelKolor17.Text = "KOLOR";
                    labelMarka17.Text = "MARKA";
                    labelPrzebieg17.Text = "PRZEBIEG";
                    labelRodzaj17.Text = "RODZAJ SAMOCHODU";
                    labelSkrzynia17.Text = "RODZAJ SKRZYNI BIEGÓW";
                    labelStan17.Text = "STAN SAMOCHODU";
                    labelUdogodnienia17.Text = "UDOGODNIENIA";
                    labelIleDrzwi17.Text = "ILU DRZWIOWY";
                    labelAdres17.Text = "ADRES GARAŻU";
                    labelNazwa17.Text = "NAZWA";
                    labelTytul17.Text = "SPECYFIKACJA SAMOCHODU";
                    buttonPowrot17.Text = "POWRÓT";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk17.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelBagaznik17.Text = "TRUNK";
                    labelKolor17.Text = "COLOR";
                    labelMarka17.Text = "BRAND";
                    labelPrzebieg17.Text = "CAR MILEAGE";
                    labelRodzaj17.Text = "CAR TYPE";
                    labelSkrzynia17.Text = "GEARBOX TYPE";
                    labelStan17.Text = "CAR CONDITION";
                    labelUdogodnienia17.Text = "AMENITIES";
                    labelIleDrzwi17.Text = "HOW MANY DOORS"; 
                    labelAdres17.Text = "GARAGE ADDRESS";
                    labelNazwa17.Text = "NAME";
                    labelTytul17.Text = "CAR SPECIFICATION";
                    buttonPowrot17.Text = "RETURN";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRejestracjaZmianaJezyk17_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk17.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk17.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk17.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelBagaznik17.Text = "TRUNK";
                    labelKolor17.Text = "COLOR";
                    labelMarka17.Text = "BRAND";
                    labelPrzebieg17.Text = "CAR MILEAGE";
                    labelRodzaj17.Text = "CAR TYPE";
                    labelSkrzynia17.Text = "GEARBOX TYPE";
                    labelStan17.Text = "CAR CONDITION";
                    labelUdogodnienia17.Text = "AMENITIES";
                    labelIleDrzwi17.Text = "HOW MANY DOORS";
                    labelAdres17.Text = "GARAGE ADDRESS";
                    labelNazwa17.Text = "NAME";
                    labelTytul17.Text = "CAR SPECIFICATION";
                    buttonPowrot17.Text = "RETURN";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk17.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk17.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelBagaznik17.Text = "BAGAŻNIK";
                    labelKolor17.Text = "KOLOR";
                    labelMarka17.Text = "MARKA";
                    labelPrzebieg17.Text = "PRZEBIEG";
                    labelRodzaj17.Text = "RODZAJ SAMOCHODU";
                    labelSkrzynia17.Text = "RODZAJ SKRZYNI BIEGÓW";
                    labelStan17.Text = "STAN SAMOCHODU";
                    labelUdogodnienia17.Text = "UDOGODNIENIA";
                    labelIleDrzwi17.Text = "ILU DRZWIOWY";
                    labelAdres17.Text = "ADRES GARAŻU";
                    labelNazwa17.Text = "NAZWA";
                    labelTytul17.Text = "SPECYFIKACJA SAMOCHODU";
                    buttonPowrot17.Text = "POWRÓT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPowrot17_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form4 PanelGlowny = new Form4(buttonRejestracjaZmianaJezyk17.Tag.ToString());
                PanelGlowny.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
