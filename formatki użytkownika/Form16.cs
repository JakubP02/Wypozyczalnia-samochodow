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
    public partial class Form16 : Form
    {
        public Form16(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk16.Tag = jezyk;
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk16.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk16.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelGaraz16.Text = "GARAŻ SIĘ NIE OTWORZYŁ";
                    labelInnyProblem16.Text = "POJAWIŁ SIĘ INNY PROBLEM /n (jeśli tak, proszę go opisać) :";
                    labelKlucz16.Text = "KLUCZ NIE PASUJE / NIE DZIAŁA";
                    labelPaliwo16.Text = "BAK PALIWA NIE JEST PEŁNY";
                    labelStanNiezgodny16.Text = "STAN NIEZGODNY Z OPISEM";
                    labelTytul16.Text = "Jaki pojawił się problem ?";
                    buttonPowrot16.Text = "POWRÓT";
                    buttonPrzeslij16.Text = "PRZEŚLIJ";
                    
                }
                else
                {
                    buttonRejestracjaZmianaJezyk16.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelGaraz16.Text = "THE GARAGE WON'T OPEN";
                    labelInnyProblem16.Text = "ANOTHER PROBLEM ARRIVED /n (if yes, please describe it):";
                    labelKlucz16.Text = "THE KEY DOES NOT FIT / DOES NOT WORK";
                    labelPaliwo16.Text = "THE FUEL TANK IS NOT FULL";
                    labelStanNiezgodny16.Text = "CONDITION NOT AS DESCRIBED";
                    labelTytul16.Text = "What was the problem?";
                    buttonPowrot16.Text = "RETURN";
                    buttonPrzeslij16.Text = "SUBMIT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPowrot16_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form15 PanelGlowny = new Form15(buttonRejestracjaZmianaJezyk16.Tag.ToString());
                PanelGlowny.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrzeslij16_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxInnyProblem16.Text = null;
                DialogResult dialogResult = MessageBox.Show("Dziękujemy za zgłoszenie usterki! \n" + "Zwrot na konto powinien zostać wykonany w ciągu 24h.", "Zgłoszenie usterki",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    Hide();
                    Form4 PanelGlowny = new Form4(buttonRejestracjaZmianaJezyk16.Tag.ToString());
                    PanelGlowny.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRejestracjaZmianaJezyk16_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk16.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk16.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk16.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelGaraz16.Text = "THE GARAGE WON'T OPEN";
                    labelInnyProblem16.Text = "ANOTHER PROBLEM ARRIVED /n (if yes, please describe it):";
                    labelKlucz16.Text = "THE KEY DOES NOT FIT / DOES NOT WORK";
                    labelPaliwo16.Text = "THE FUEL TANK IS NOT FULL";
                    labelStanNiezgodny16.Text = "CONDITION NOT AS DESCRIBED";
                    labelTytul16.Text = "What was the problem?";
                    buttonPowrot16.Text = "RETURN";
                    buttonPrzeslij16.Text = "SUBMIT";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk16.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk16.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelGaraz16.Text = "GARAŻ SIĘ NIE OTWORZYŁ";
                    labelInnyProblem16.Text = "POJAWIŁ SIĘ INNY PROBLEM /n (jeśli tak, proszę go opisać) :";
                    labelKlucz16.Text = "KLUCZ NIE PASUJE / NIE DZIAŁA";
                    labelPaliwo16.Text = "BAK PALIWA NIE JEST PEŁNY";
                    labelStanNiezgodny16.Text = "STAN NIEZGODNY Z OPISEM";
                    labelTytul16.Text = "Jaki pojawił się problem ?";
                    buttonPowrot16.Text = "POWRÓT";
                    buttonPrzeslij16.Text = "PRZEŚLIJ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
