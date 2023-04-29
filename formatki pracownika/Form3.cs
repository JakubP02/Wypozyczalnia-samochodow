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

namespace wypożyczalnia_pracownik
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ZarzadanieFinansami finanse = new ZarzadanieFinansami();
            decimal zyski = finanse.Zyski();
            decimal straty = finanse.Straty();
            label2.Text = zyski.ToString();
            label3.Text = straty.ToString();
            label7.Text = finanse.Bilans(zyski, straty).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
