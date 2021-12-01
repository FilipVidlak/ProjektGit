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
    public partial class Ukol1 : Form
    {
        public Ukol1()
        {
            InitializeComponent();
        }

        private void Ukol1_Load(object sender, EventArgs e)
        {
            string pismena = "QERTYUIOPASDFGHJKLZXCVBNM.,?!";
            int i = 0;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button) { (ctrl as Button).Text = pismena[i].ToString(); i++; }
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string nwtext = "";
            int numb = 3;
            string text = textBox1.Text;
            text = text.ToLower();
            char[] znaky = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (znaky[i].ToString() == " " || znaky[i].ToString() == "." || znaky[i].ToString() == "," || znaky[i].ToString() == "!" || znaky[i].ToString() == "?") { }
                else
                {
                    int temp = (int)znaky[i];
                    temp += numb;
                    if (temp > 122) { temp -= 26; }
                    znaky[i] = (char)temp;
                }
                nwtext += znaky[i].ToString();

            }
            textBox1.Text = nwtext.ToUpper();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string nwtext = "";
            int numb = 3;
            string text = textBox1.Text;
            text = text.ToLower();
            char[] znaky = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                if (znaky[i].ToString() == " " || znaky[i].ToString() == "." || znaky[i].ToString() == "," || znaky[i].ToString() == "!" || znaky[i].ToString() == "?") { }
                else
                {
                    int temp = (int)znaky[i];
                    temp -= numb;
                    if (temp < 122-25) { temp += 26; }
                    znaky[i] = (char)temp;
                }
                nwtext += znaky[i].ToString();

            }
            textBox1.Text = nwtext.ToUpper();
        }
    }
}
