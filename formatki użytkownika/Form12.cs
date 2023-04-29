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
    public partial class Form12 : Form
    {
        public Form12(string jezyk)
        {
            InitializeComponent();
            labelDokonczPlatnoscBlik12.Tag = jezyk;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            try
            {
                if (labelDokonczPlatnoscBlik12.Tag.ToString() == "Ang")
                {
                    labelDokonczPlatnoscBlik12.Text = "DOKOŃCZ PŁATNOŚĆ";
                    labelKodBlik12.Text = "KOD BLIK :";
                    labelKoszt12.Text = "KOSZT OPERACJI";
                    buttonPotwierdz12.Text = "POTWIERDŹ";
                    buttonPowrot12.Text = "POWRÓT";
                }
                else
                {
                    labelDokonczPlatnoscBlik12.Text = "THE PAYMENT";
                    labelKodBlik12.Text = "BLIK CODE";
                    labelKoszt12.Text = "COSTS";
                    buttonPotwierdz12.Text = "CONFIRM";
                    buttonPowrot12.Text = "RETURN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPowrot12_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form11 Wypozyczenia = new Form11(labelDokonczPlatnoscBlik12.Tag.ToString());
                Wypozyczenia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPotwierdz12_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form14 Potwierdzenie = new Form14(labelDokonczPlatnoscBlik12.Tag.ToString());
                Potwierdzenie.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
