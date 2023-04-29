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
    public partial class Form15 : Form
    {
        public Form15(string jezyk)
        {
            InitializeComponent();
            labelTytul15.Tag = jezyk;
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            try
            {
                if (labelTytul15.Tag.ToString() == "Ang")
                {
                    labelTytul15.Text= "CZY ODEBRANO KLUCZE ? /n CZY SPRAWDZONO SAMOCHOD ? ";
                    labelKlucze15.Text = "ODEBRANO KLUCZE";
                    labelStanPojazdu15.Text = "SPRAWDZONO STAN /n POJAZDU";
                    buttonRozpocznij15.Text = "ROZPOCZNIJ";
                    buttonZglosUsterke15.Text = "ZGŁOŚ USTERKĘ";
                }
                else
                {
                    labelTytul15.Text = "HAVE THE KEYS BEEN RECEIVED ? / n HAS THE CAR BE CHECKED?";
                    labelKlucze15.Text = "KEYS RECEIVED";
                    labelStanPojazdu15.Text = "CAR CONDITION /n CHECKED";
                    buttonRozpocznij15.Text = "START";
                    buttonZglosUsterke15.Text = "REPORT A PROBLEM";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonZglosUsterke15_Click(object sender, EventArgs e)
        {
            try
            {
                //
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRozpocznij15_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form4 PanelGlowny = new Form4(labelTytul15.Tag.ToString());
                PanelGlowny.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
