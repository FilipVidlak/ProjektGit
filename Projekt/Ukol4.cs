using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Ukol4 : Form
    {
        public Ukol4()
        {
            InitializeComponent();
        }

        private void vypocitat_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = comboBox1.Text;

                double mocnina = Convert.ToDouble(comboBox1.Text);

                double cislo1 = Convert.ToDouble(textBox1.Text);
                double cislo2 = Convert.ToDouble(textBox2.Text);
                double cislo3 = Convert.ToDouble(textBox3.Text);

                cislo1 = Math.Pow(cislo1, mocnina);
                cislo2 = Math.Pow(cislo2, mocnina);
                cislo3 = Math.Pow(cislo3, mocnina);

                textBox1.Text = Convert.ToString(cislo1);
                textBox2.Text = Convert.ToString(cislo2);
                textBox3.Text = Convert.ToString(cislo3);
            }
            catch { MessageBox.Show("Chyba!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Ukol4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
