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
    public partial class Form9 : Form
    {
        WypozyczalniaAut.Logic.OtwieranieNowychOkien PowrotDoOknaLogowania = new WypozyczalniaAut.Logic.OtwieranieNowychOkien();
        
        
        public Form9(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk9.Tag = jezyk;
        }

        private void buttonPowrot9_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk9.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk9.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelNoweHaslo9.Text = "Nowe hasło :";
                    labelNoweHasloPowtorz9.Text = "Powtórz nowe \n hasło :";
                    labelStareHaslo9.Text = "Stare hasło: ";
                    labelZmianaHasla9.Text = "ZMIANA HASŁA";
                    buttonAktualizuj9.Text = "AKTUALIZUJ";
                    buttonPowrot9.Text = "POWRÓT";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk9.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelNoweHaslo9.Text = "New password :";
                    labelNoweHasloPowtorz9.Text = "Repeat \n new password :";
                    labelStareHaslo9.Text = "Old password :";
                    labelZmianaHasla9.Text = "PASSWORD CHANGE";
                    buttonAktualizuj9.Text = "UPDATE";
                    buttonPowrot9.Text = "RETURN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAktualizuj9_Click(object sender, EventArgs e)
        {
            string StareHasło = textBoxZmianaHaslaStare9.Text;
            string NoweHasło = textBoxZmianaHaslaNowe9.Text;
            string NoweHasłoPow = textBoxZmianaHaslaNowePowtorz9.Text;
            try
            {
                if (PowrotDoOknaLogowania.PowrotPoZmianieHasła(StareHasło, NoweHasło, NoweHasłoPow))
                {
                    Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonRejestracjaZmianaJezyk9_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk9.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk9.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk9.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelNoweHaslo9.Text = "New password :";
                    labelNoweHasloPowtorz9.Text = "Repeat \n new password :";
                    labelStareHaslo9.Text = "Old password :";
                    labelZmianaHasla9.Text = "PASSWORD CHANGE";
                    buttonAktualizuj9.Text = "UPDATE";
                    buttonPowrot9.Text = "RETURN";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk9.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk9.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelNoweHaslo9.Text = "Nowe hasło :";
                    labelNoweHasloPowtorz9.Text = "Powtórz nowe \n hasło :";
                    labelStareHaslo9.Text = "Stare hasło: ";
                    labelZmianaHasla9.Text = "ZMIANA HASŁA";
                    buttonAktualizuj9.Text = "AKTUALIZUJ";
                    buttonPowrot9.Text = "POWRÓT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    
}
