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
using WypozyczalniaAut.Model;

namespace wypożyczalnia_pracownik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ObslugaBazy obslugaBazy = new ObslugaBazy();
            List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();
            wypozyczenia = obslugaBazy.ReadFromFileWypozyczenia(ObslugaBazy.PlikWypozyczenia);
            foreach (Wypozyczenie w in wypozyczenia)
            {
                listBox1.Items.Add("(IdPojazdu, IdKlienta )"+ w);

            }
            comboBox1.Items.Add("Zablokowany");
            comboBox1.Items.Add("Weryfikacja");
            comboBox1.Items.Add("Aktywny");
            foreach (Klient k in obslugaBazy.ReadFromFileUser(ObslugaBazy.PlikUserList))
            {
                listBox2.Items.Add(k.Id.ToString() + "  Pełne dane: "+  k);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
            {
                ObslugaBazy obslugaBazy = new ObslugaBazy();
                List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();
                wypozyczenia = obslugaBazy.ReadFromFileWypozyczenia(ObslugaBazy.PlikWypozyczenia);
                ZarzadzanieKlientami daneklientow = new ZarzadzanieKlientami(); 
                string status = comboBox1.Text;
                int indeksKlienta = 0;
                string input = listBox2.SelectedItem.ToString();
                string idTekst = input.Substring(0, input.IndexOf(" "));
                indeksKlienta = int.Parse(idTekst);
                // zmieniam status
                daneklientow.ZmianaStatusuKlienta(indeksKlienta, status);
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                foreach (Wypozyczenie w in wypozyczenia)
                {
                    listBox1.Items.Add("(IdPojazdu, IdKlienta )" + w);

                }
                foreach (Klient k in obslugaBazy.ReadFromFileUser(ObslugaBazy.PlikUserList))
                {
                    listBox2.Items.Add(k.Id.ToString() + "  Pełne dane: " + k);
                }
                Console.WriteLine(indeksKlienta);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal dodanaWforms = numericUpDown1.Value;
            ZarzadanieFinansami finanse = new ZarzadanieFinansami();
            finanse.AktualizacjaKosztówPracownika(ObslugaBazy.pracownik.Id, dodanaWforms);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  
            form3.ShowDialog();

        }
    }
}
