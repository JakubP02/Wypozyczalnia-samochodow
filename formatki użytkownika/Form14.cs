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
    public partial class Form14 : Form
    {
        public Form14(string jezyk)
        {
            InitializeComponent();
            labelDziekujemy14.Tag = jezyk;
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            try
            {
                if (labelDziekujemy14.Tag.ToString() == "Ang")
                {
                    labelDziekujemy14.Text = "DZIĘKUJEMY!";
                    labelPotwierdzenie14.Text = "TWOJA PŁATNOŚĆ ZOSTAŁA ZATWIERDZONA";
                }
                else
                {
                    labelDziekujemy14.Text = "THANK YOU!";
                    labelPotwierdzenie14.Text = "YOUR PAYMENT HAS BEEN APPROVED";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOk14_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                Form15 Odbieranie = new Form15(labelDziekujemy14.Tag.ToString());
                Odbieranie.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. \n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
