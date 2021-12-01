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
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
        
            InitializeComponent();
        }

        private void Ukol2_Load(object sender, EventArgs e)
        {
            Random rng = new Random();
            for (int i = 0; i < 10; i++) listBox1.Items.Add(rng.Next(0, 10));

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = (listBox1.SelectedItems.Count.ToString());
            int total = 0;
            foreach (var a in listBox1.SelectedItems)
            { 
                total += int.Parse(a.ToString());
            }
           label2.Text = (total.ToString()); 
        }
    }
}
