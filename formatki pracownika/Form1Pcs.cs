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
    public partial class Form1Pcs : Form
    {
        public Form1Pcs()
        {
            InitializeComponent();
        }

        private void Form1Pcs_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ObslugaBazy obslugabazy= new ObslugaBazy();
            List<Pracownik> pracownik = new List <Pracownik>();
            pracownik = obslugabazy.ReadFromFilePracownik(ObslugaBazy.PlikPracownik);
            ObslugaBazy.listaPracownikow = pracownik;
            foreach (Pracownik p in pracownik)
            { 
                comboBox1.Items.Add(p.Id);
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {


            int Id = Convert.ToInt16(comboBox1.SelectedItem);
            string haslo = textBox1.Text;
            string komunikat = "Błedny login";


                OtwieranieNowychOkien noweOknoPracownika = new OtwieranieNowychOkien();

                if (noweOknoPracownika.WeryfikacjaHaslaPracownika(Id, haslo, ref komunikat) == true)
                {
                    Form2 form2 = new Form2();
                    Pracownik prac = new Pracownik();
                    prac.Id = Id; prac.haslo = haslo;
                    ObslugaBazy.pracownik = prac;
                    MessageBox.Show(komunikat);
                    MessageBox.Show("Zalogowano jako pracownik nr " + ObslugaBazy.pracownik.Id.ToString());
                    Hide();
                    form2.ShowDialog();
                  

                }
                else
                {
                    MessageBox.Show(komunikat);
                }
            }

        }
    }
}
