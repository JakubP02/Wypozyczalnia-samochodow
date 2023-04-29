using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WypozyczalniaAut;
using WypozyczalniaAut.Logic;
using WypozyczalniaAut.Model;

namespace WypozyczalniaSamochodow
{
    public partial class Form5 : Form
    {
        public Form5(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk5.Tag = jezyk;
        }
         private void Form5_Load(object sender, EventArgs e)
         {
            try
            {
                foreach (string marka in Filtracja.Marki())
                { 
                    comboBoxFiltryMarka5.Items.Add(marka);
                }
                foreach (string model in Filtracja.Modele())
                {
                    comboBoxFiltryModel5.Items.Add(model);
                }
                foreach (decimal poj in Filtracja.PojemnosciDolneGranice())
                {
                    comboBoxFiltryPojemnosc5.Items.Add(poj.ToString() + " - " + (poj+500).ToString());
                }
                foreach (string garaz in Filtracja.garaz())
                {
                    comboBoxFiltryGaraz5.Items.Add(garaz.ToString());
                }
                


                if (buttonRejestracjaZmianaJezyk5.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk5.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelFiltrMarka5.Text = "Marka";
                    labelFiltrModel5.Text = "Model";
                    labelFiltrPojemnosc5.Text = "Pojemność silnika";
                    labelFiltryGaraż5.Text = "Garaż";
                    buttonFiltruj5.Text = "FILTRUJ";
                    buttonPowrot5.Text = "POWRÓT";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk5.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelFiltrMarka5.Text = "Brand";
                    labelFiltrModel5.Text = "Model";
                    labelFiltrPojemnosc5.Text = "Engine capacity";
                    labelFiltryGaraż5.Text = "Garage";
                    buttonFiltruj5.Text = "FILTER";
                    buttonPowrot5.Text = "RETURN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRejestracjaZmianaJezyk5_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk5.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk5.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk5.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelFiltrMarka5.Text = "Brand";
                    labelFiltrModel5.Text = "Model";
                    labelFiltrPojemnosc5.Text = "Engine capacity";
                    labelFiltryGaraż5.Text = "Garage";
                    buttonFiltruj5.Text = "FILTER";
                    buttonPowrot5.Text = "RETURN";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk5.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk5.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelFiltrMarka5.Text = "Marka";
                    labelFiltrModel5.Text = "Model";
                    labelFiltrPojemnosc5.Text = "Pojemność silnika";
                    labelFiltryGaraż5.Text = "Garaż";
                    buttonFiltruj5.Text = "FILTRUJ";
                    buttonPowrot5.Text = "POWRÓT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFiltruj5_Click(object sender, EventArgs e)
        {

            try
            {
                Filtracja.parametryFiltrowania.Marka = comboBoxFiltryMarka5.Text.ToString();
              
                Filtracja.parametryFiltrowania.Model = comboBoxFiltryModel5.Text.ToString();
          
                Filtracja.parametryFiltrowania.Pojemnosc = Convert.ToDecimal(comboBoxFiltryPojemnosc5.Text.Substring(0, 4));

                Filtracja.parametryFiltrowania.garaż = comboBoxFiltryGaraz5.Text.ToString();
          



                Hide();
                Form4 PanelGlowny = new Form4(buttonRejestracjaZmianaJezyk5.Tag.ToString());
                PanelGlowny.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPowrot5_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form4 PanelGlowny = new Form4(buttonRejestracjaZmianaJezyk5.Tag.ToString());
                PanelGlowny.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxFiltryPrzebieg5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFiltryUdogodnienia5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
