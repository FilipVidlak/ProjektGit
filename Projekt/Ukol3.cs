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
    public partial class Ukol3 : Form
    {
        public Ukol3()
        {
            InitializeComponent();
        }

        private void prumer_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = listBox1.SelectedItem.ToString();
                label2.Text = listBox1.SelectedItem.ToString();
                label3.Text = listBox1.SelectedItem.ToString();

                int cislo1 = Convert.ToInt32(textBox1.Text);
                int cislo2 = Convert.ToInt32(textBox2.Text);
                int cislo3 = Convert.ToInt32(textBox3.Text);

                double vysledek = ((double)cislo1 + (double)cislo2 + (double)cislo3) / 3;

                MessageBox.Show("Aritmetrický průměr čísel je " + Math.Round(vysledek,2), "Výsledek", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Musíš zadat číslo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ukol3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
