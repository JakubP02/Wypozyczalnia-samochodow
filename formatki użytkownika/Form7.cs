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
    public partial class Form7 : Form
    {
        public Form7(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk7.Tag = jezyk;
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk7.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk7.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelRegulamin7.Text = "REGULAMIN";
                    buttonPowrot7.Text = "POWRÓT";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk7.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelRegulamin7.Text = "STATUTE";
                    buttonPowrot7.Text = "RETURN"; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRejestracjaZmianaJezyk7_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk7.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk7.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk7.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelRegulamin7.Text = "STATUTE";
                    buttonPowrot7.Text = "RETURN";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk7.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk7.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelRegulamin7.Text = "REGULAMIN";
                    buttonPowrot7.Text = "POWRÓT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPowrot7_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form3 Rejestracja = new Form3(buttonRejestracjaZmianaJezyk7.Tag.ToString());
                Rejestracja.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
