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
    public partial class Form1 : Form
    {
        public Form1(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk1.Tag = jezyk;
        }

        public Form1()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filtracja.parametryFiltrowania.Marka = "";
            Filtracja.parametryFiltrowania.Model = "";
            Filtracja.parametryFiltrowania.garaż = "";
            Filtracja.parametryFiltrowania.Pojemnosc = 0;

            try
            {
                if (buttonRejestracjaZmianaJezyk1.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk1.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    ButtonZarejestruj1.Text = "Zarejestruj się";
                    ButtonZaloguj1.Text = "Zaloguj się";
                    buttonWyjdź1.Text = "Wyjdź";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk1.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    ButtonZarejestruj1.Text = "Sign Up";
                    ButtonZaloguj1.Text = "Log in";
                    buttonWyjdź1.Text = "Exit";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nie oczekiwany błąd. \n" + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonZarejestruj1_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form3 OknoRejestracji = new Form3(buttonRejestracjaZmianaJezyk1.Tag.ToString());
                OknoRejestracji.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nie oczekiwany błąd. \n" + ex.Message);
            }
        }

        private void ButtonZaloguj1_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form2 OknoLogowania = new Form2(buttonRejestracjaZmianaJezyk1.Tag.ToString());
                OknoLogowania.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nie oczekiwany błąd. \n" + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonWyjdź1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz wyjść?", "Zamykanie aplikacji",
               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                else if (dialogResult == DialogResult.No)
                    return;
                else if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                    System.Windows.Forms.Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonRejestracjaZmianaJezyk1_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk1.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk1.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk1.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    ButtonZarejestruj1.Text = "Sign Up";
                    ButtonZaloguj1.Text = "Log in";
                    buttonWyjdź1.Text = "Exit";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk1.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk1.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    ButtonZarejestruj1.Text = "Zarejestruj się";
                    ButtonZaloguj1.Text = "Zaloguj się";
                    buttonWyjdź1.Text = "Wyjdź";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
