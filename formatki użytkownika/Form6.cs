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
    public partial class Form6 : Form
    {
        public Form6(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk6.Tag = jezyk;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk6.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk6.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelOpinia6.Text = "Napisz opinię :";
                    buttonPowrot6.Text = "POWRÓT";
                    buttonPrzeslij6.Text = "PRZEŚLIJ";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk6.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelOpinia6.Text = "Write a review :";
                    buttonPowrot6.Text = "RETURN";
                    buttonPrzeslij6.Text = "SEND";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRejestracjaZmianaJezyk6_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk6.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk6.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk6.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelOpinia6.Text = "Write a review :";
                    buttonPowrot6.Text = "RETURN";
                    buttonPrzeslij6.Text = "SEND";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk6.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk6.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelOpinia6.Text = "Napisz opinię :";
                    buttonPowrot6.Text = "POWRÓT";
                    buttonPrzeslij6.Text = "PRZEŚLIJ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPowrot6_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form4 PanelGlowny = new Form4(buttonRejestracjaZmianaJezyk6.Tag.ToString());
                PanelGlowny.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrzeslij6_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOpinia6.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
