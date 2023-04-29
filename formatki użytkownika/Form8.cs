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
using WypozyczalniaSamochodow;

namespace WypozyczalniaSamochodow
{
    public partial class Form8 : Form
    {
        WypozyczalniaAut.Logic.OtwieranieNowychOkien noweOkno = new WypozyczalniaAut.Logic.OtwieranieNowychOkien();

        public Form8(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk8.Tag = jezyk;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk8.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk8.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelMojProfil8.Text = "MÓJ PROFIL";
                    labelImie8.Text = "Imie";
                    labelNazwisko8.Text = "Nazwisko";
                    labelHaslo8.Text = "Hasło";
                    buttonZmianaHasla8.Text = "ZMIEŃ";
                    buttonPowrot8.Text = "POWRÓT";
                    buttonProfilZalaczZdjecie8.Text = "ZMIEŃ \n" +
                        "ZDJĘCIE";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk8.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelMojProfil8.Text = "MY PROFILE";
                    labelImie8.Text = "First Name";
                    labelNazwisko8.Text = "Last Name";
                    labelHaslo8.Text = "Password";
                    buttonZmianaHasla8.Text = "CHANGE";
                    buttonPowrot8.Text = "RETURN";
                    buttonProfilZalaczZdjecie8.Text = "CHANGE \n" +
                        "PHOTO";
                }

                textBoxProfilImie8.Text = ObslugaBazy.daneZalogowanegoUzytkownika.Imie;
                            textBoxProfilEmail8.Text = ObslugaBazy.daneZalogowanegoUzytkownika.Email;
                            textBoxProfilLogin8.Text = ObslugaBazy.daneZalogowanegoUzytkownika.login;
                            textBoxProfilNazwisko8.Text = ObslugaBazy.daneZalogowanegoUzytkownika.Nazwisko;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonZmianaHasla8_Click(object sender, EventArgs e)
        {
            try
            {
                Form9 FormatkaDoZmianyHasla = new Form9(buttonRejestracjaZmianaJezyk8.Tag.ToString());
                FormatkaDoZmianyHasla.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRejestracjaZmianaJezyk8_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk8.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk8.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk8.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelMojProfil8.Text = "MY PROFILE";
                    labelImie8.Text = "First Name";
                    labelNazwisko8.Text = "Last Name";
                    labelHaslo8.Text = "Password";
                    buttonZmianaHasla8.Text = "CHANGE";
                    buttonPowrot8.Text = "RETURN";

                    buttonProfilZalaczZdjecie8.Text = "CHANGE \n" +
                        "PHOTO";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk8.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk8.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelMojProfil8.Text = "MÓJ PROFIL";
                    labelImie8.Text = "Imie";
                    labelNazwisko8.Text = "Nazwisko";
                    labelHaslo8.Text = "Hasło";
                    buttonZmianaHasla8.Text = "ZMIEŃ";
                    buttonPowrot8.Text = "POWRÓT";
                    buttonProfilZalaczZdjecie8.Text = "ZMIEŃ \n" +
                        "ZDJĘCIE";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAktualizuj8_Click(object sender, EventArgs e)
        {

        }

        private void buttonPowrot8_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form4 PanelGlowny = new Form4(buttonRejestracjaZmianaJezyk8.Tag.ToString());
                PanelGlowny.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonProfilZalaczZdjecie8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxProfilImie8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
