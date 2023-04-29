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
    public partial class Form13 : Form
    {
        public Form13(string jezyk)
        {
            InitializeComponent();
            labelDokonczPlatnoscPrzelew13.Tag = jezyk;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            try
            {
                if (labelDokonczPlatnoscPrzelew13.Tag.ToString() == "Ang")
                {
                    labelDokonczPlatnoscPrzelew13.Text = "DOKOŃCZ PŁATNOŚĆ";
                    labelDanePrzelew13.Text = "DANE DO PRZELEWU :";
                    labelKwota13.Text = "KWOTA :";
                    labelNrKonta13.Text = "NR KONTA :";
                    labelNrZamowienie13.Text = "NR. ZAMÓWIENIA :";
                    labelWTytule13.Text = "W TYTULE ZAŁĄCZ :";
                    labelWTytuleSzczegoly13.Text = "- Login \n" +
                        "- Numer zamówienia";
                }
                else
                {
                    labelDokonczPlatnoscPrzelew13.Text = "THE PAYMENT";
                    labelDanePrzelew13.Text = "BANK TRANSFER DETAILS :";
                    labelKwota13.Text = "SUM :";
                    labelNrKonta13.Text = "NO. ACCOUNTS :";
                    labelNrZamowienie13.Text = "NO. ORDERS :";
                    labelWTytule13.Text = "IN THE TITLE, ATTACH:";
                    labelWTytuleSzczegoly13.Text = "- Login \n" +
                        "- Order number";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPowrot13_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form11 Wypozyczenia = new Form11(labelDokonczPlatnoscPrzelew13.Tag.ToString());
                Wypozyczenia.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPotwierdz13_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form14 Potwierdzenie = new Form14(labelDokonczPlatnoscPrzelew13.Tag.ToString());
                Potwierdzenie.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
