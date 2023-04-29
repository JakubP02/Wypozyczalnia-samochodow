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
using WypozyczalniaAut.Model;

namespace WypozyczalniaSamochodow
{
    public partial class Form3 : Form
    {
        //w tym formsie wprowadzamy dane i jesli regulamin zaakceptowano to wtedy wywolujemy funkcje z danymi usera i wrzucamy do bazy poczekalnia 
        WypozyczalniaAut.Klient rejestrujący = new WypozyczalniaAut.Klient();
        OtwieranieNowychOkien OknoPoRejestracji = new OtwieranieNowychOkien();
        public Form3(string jezyk)
        {
            InitializeComponent();
            buttonRejestracjaZmianaJezyk3.Tag = jezyk.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk3.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk3.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelImie3.Text = "Imie";
                    labelNazwisko3.Text = "Nazwisko";
                    labelPrawoJazdy3.Text = "Numer prawa jazdy";
                    labelDataUrodzenia3.Text = "Data urodzenia";
                    labelHaslo3.Text = "Hasło";
                    labelHasloPowtorz3.Text = "Hasło (wpisz ponownie)";
                    labelAkceptuje3.Text = "Akceptuję";
                    linkLabelRegulamin3.Text = "Regulamin";
                    buttonZarejestruj3.Text = "Zarejestruj się";
                    ButtonPowrot3.Text = "Powrót";
                    buttonRejestracjaZalaczZdjecie3.Text = "Załącz zdjęcie";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk3.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelImie3.Text = "First Name";
                    labelNazwisko3.Text = "Last Name";
                    labelPrawoJazdy3.Text = "Driving license number";
                    labelDataUrodzenia3.Text = "Date of birth";
                    labelHaslo3.Text = "Password";
                    labelHasloPowtorz3.Text = "Repeat password";
                    labelAkceptuje3.Text = "I accept";
                    linkLabelRegulamin3.Text = "the terms and conditions";
                    buttonZarejestruj3.Text = "Sign Up";
                    ButtonPowrot3.Text = "Return";
                    buttonRejestracjaZalaczZdjecie3.Text = "Add a photo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message);
            }
        }
        private void buttonPowrot3_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form1 OknoStart = new Form1(buttonRejestracjaZmianaJezyk3.Tag.ToString());
                OknoStart.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonZarejestruj3_Click(object sender, EventArgs e)
        {
            string komunikat = "Dziękujemy za poprawną rejestrację! Na twoją skrzynkę mailową przyjdzie wiadomość, gdy jeden z naszych pracowników zweryfikuje konto";
            rejestrujący.Id = 0;
            rejestrujący.Imie = textBoxRejestracjaImie3.Text;
            rejestrujący.Nazwisko = textBoxRejestracjaNazwisko3.Text;
            rejestrujący.Email = textBoxRejestracjaEmail3.Text;
            rejestrujący.Pesel = maskedTextBoxRejestracjaPesel3.Text;
            rejestrujący.login = textBoxRejestracjaLogin3.Text;
            rejestrujący.haslo = textBoxRejestracjaHaslo3.Text;
            rejestrujący.NrPrawaJazdy = textBoxNrPrawaJazdy3.Text;
            
           
                rejestrujący.DataUrodzenia = dateTimePickerRejestracjaDataUrodzenia3.Value;
            
        
            
            string powtorzoneHaslo = textBoxRejestracjaHasloPowtorz3.Text;
            bool zaakceptowanyRegulamin = checkBoxRejestracjaRegulamin3.Checked;

            if (OknoPoRejestracji.TworzenieNowegoPrfilu(rejestrujący, ObslugaBazy.PlikUserList, powtorzoneHaslo, zaakceptowanyRegulamin, ref komunikat))
            {
                try
                {
                    MessageBox.Show(komunikat);
                    Hide();
                    Form1 OknoStart = new Form1(buttonRejestracjaZmianaJezyk3.Tag.ToString());
                    OknoStart.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(komunikat);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRejestracjaZmianaJezyk3_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonRejestracjaZmianaJezyk3.Tag.ToString() == "Ang")
                {
                    buttonRejestracjaZmianaJezyk3.Tag = "Pl";
                    buttonRejestracjaZmianaJezyk3.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaPolski);
                    labelImie3.Text = "First Name";
                    labelNazwisko3.Text = "Last Name";
                    labelPrawoJazdy3.Text = "Driving license number";
                    labelDataUrodzenia3.Text = "Date of birth";
                    labelHaslo3.Text = "Password";
                    labelHasloPowtorz3.Text = "Repeat password";
                    labelAkceptuje3.Text = "I accept";
                    linkLabelRegulamin3.Text = "the terms and conditions";
                    buttonZarejestruj3.Text = "Sign Up";
                    ButtonPowrot3.Text = "Return";
                    buttonRejestracjaZalaczZdjecie3.Text = "Add a photo";
                }
                else
                {
                    buttonRejestracjaZmianaJezyk3.Tag = "Ang";
                    buttonRejestracjaZmianaJezyk3.Image = Image.FromFile(OtwieranieNowychOkien.ObrazFlagaAngli);
                    labelImie3.Text = "Imie";
                    labelNazwisko3.Text = "Nazwisko";
                    labelPrawoJazdy3.Text = "Numer prawa jazdy";
                    labelDataUrodzenia3.Text = "Data urodzenia";
                    labelHaslo3.Text = "Hasło";
                    labelHasloPowtorz3.Text = "Hasło (wpisz ponownie)";
                    labelAkceptuje3.Text = "Akceptuję";
                    linkLabelRegulamin3.Text = "Regulamin";
                    buttonZarejestruj3.Text = "Zarejestruj się";
                    ButtonPowrot3.Text = "Powrót";
                    buttonRejestracjaZalaczZdjecie3.Text = "Załącz zdjęcie";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void maskedTextBoxRejestracjaPesel3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRejestracjaRegulamin3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelRegulamin3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Hide();
                Form7 Regulamin = new Form7(buttonRejestracjaZmianaJezyk3.Tag.ToString());
                Regulamin.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
