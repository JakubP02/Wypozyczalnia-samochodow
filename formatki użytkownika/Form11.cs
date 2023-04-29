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
    public partial class Form11 : Form
    {
        public Form11(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk11.Tag = jezyk;
        }
        private void Form11_Load(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk11.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk11.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli); ;
                    
                    labelWybierzPlatnosc11.Text = "WYBIERZ METODĘ PŁATNOŚCI \n" +
                        "ABY PRZEJŚĆ DALEJ";
                    labelWypozyczanie11.Text = "WYPOŻYCZANIE";
                    buttonPowrot11.Text = "POWRÓT";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk11.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    
                    labelWybierzPlatnosc11.Text = "SELECT A PAYMENT METHOD \n" +
                        "TO PROCEED";
                    labelWypozyczanie11.Text = "RENTAL";
                    buttonPowrot11.Text = "RETURN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRejestracjaZmianaJezyk11_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk11.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk11.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk11.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                   
                    labelWybierzPlatnosc11.Text = "SELECT A PAYMENT METHOD \n" +
                        "TO PROCEED";
                    labelWypozyczanie11.Text = "RENTAL";
                    buttonPowrot11.Text = "RETURN";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk11.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk11.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli); ;
                   
                    labelWybierzPlatnosc11.Text = "WYBIERZ METODĘ PŁATNOŚCI \n" +
                        "ABY PRZEJŚĆ DALEJ";
                    labelWypozyczanie11.Text = "WYPOŻYCZANIE";
                    buttonPowrot11.Text = "POWRÓT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPowrot11_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form4 PanelGlowny = new Form4(buttonRejestracjaZmianaJezyk11.Tag.ToString());
                PanelGlowny.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWypozyczanieMetodaBlik11_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form12 PlatnoscBlik = new Form12(buttonRejestracjaZmianaJezyk11.Tag.ToString());
                PlatnoscBlik.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonWypozyczanieMetodaPrzelew11_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form13 PlatnoscPrzelew = new Form13(buttonRejestracjaZmianaJezyk11.Tag.ToString());
                PlatnoscPrzelew.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
