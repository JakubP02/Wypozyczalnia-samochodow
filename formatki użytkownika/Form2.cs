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



namespace WypozyczalniaSamochodow
{
    public partial class Form2 : Form
    {
        WypozyczalniaAut.Logic.OtwieranieNowychOkien noweOkno = new WypozyczalniaAut.Logic.OtwieranieNowychOkien();
      
       

        public Form2(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk2.Tag = jezyk;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

            try
            {
                if (buttonRejestracjaZmianaJezyk2.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk2.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelHaslo2.Text = "Hasło";
                    buttonPowrot2.Text = "POWRÓT";
                    buttonZaloguj2.Text = "ZALOGUJ SIĘ";
                    buttonZmienHaslo2.Text = "Zmień hasło";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk2.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelHaslo2.Text = "Password";
                    buttonPowrot2.Text = "RETURN";
                    buttonZaloguj2.Text = "LOG IN";
                    buttonZmienHaslo2.Text = "Change password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonZaloguj2_Click(object sender, EventArgs e)
        {
            string Login = textBoxLogin2.Text;
            string Hasło = textBoxHaslo2.Text;
            string KomunikatBlad = "Błędne dane logowania!";
            try
            {
                if (noweOkno.CzyPoprawnyLogin(Login, Hasło, KomunikatBlad))
                {
                    Form4 FormatkaGłowna = new Form4(buttonRejestracjaZmianaJezyk2.Tag.ToString());
                    Hide();
                    FormatkaGłowna.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            

        private void buttonRejestracjaZmianaJezyk2_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk2.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk2.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk2.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelHaslo2.Text = "Password";
                    buttonPowrot2.Text = "RETURN";
                    buttonZaloguj2.Text = "LOG IN";
                    buttonZmienHaslo2.Text = "Change password";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk2.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk2.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelHaslo2.Text = "Hasło";
                    buttonPowrot2.Text = "POWRÓT";
                    buttonZaloguj2.Text = "ZALOGUJ SIĘ";
                    buttonZmienHaslo2.Text = "Zmień hasło";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPowrot2_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form1 OknoStart = new Form1(buttonRejestracjaZmianaJezyk2.Tag.ToString());
                OknoStart.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonZmienHaslo2_Click(object sender, EventArgs e)
        {
            Form9 ZmianaHasla = new Form9(buttonRejestracjaZmianaJezyk2.Tag.ToString());
            string Login = textBoxLogin2.Text;
            string Hasło = textBoxHaslo2.Text;
            string KomunikatBlad = "Błędne dane logowania!";
            try
            {
                if (noweOkno.CzyPoprawnyLogin(Login, Hasło, KomunikatBlad))
                {
                    ZmianaHasla.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
