using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string s = Conta.Text.Substring(0, Conta.Text.Length - 1);
           Conta.Text = s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numero0_Click(object sender, EventArgs e)
        {
            if (Conta.Text.Length < 11)
            {
                Conta.Text += "0";
            }
        }

        private void numero1_Click(object sender, EventArgs e)
        {
            if (Conta.Text.Length < 11)
            {
                Conta.Text += "1";
            }
        }

        private void numero2_Click(object sender, EventArgs e)
        {
            if (Conta.Text.Length < 11)
            {
                Conta.Text += "2";
            }
        }

        private void numero3_Click(object sender, EventArgs e)
        {
            if (Conta.Text.Length < 11)
            {
                Conta.Text += "3";
            }
        }

        private void numero4_Click(object sender, EventArgs e)
        {
            if (Conta.Text.Length < 11)
            {
                Conta.Text += "4";
            }
        }

        private void numero5_Click(object sender, EventArgs e)
        {
            if (Conta.Text.Length < 11)
            {
                Conta.Text += "5";
            }
        }

        private void numero6_Click(object sender, EventArgs e)
        {
            if (Conta.Text.Length < 11)
            {
                Conta.Text += "6";
            }
        }

        private void numero7_Click(object sender, EventArgs e)
        {
            if (Conta.Text.Length < 11)
            {
                Conta.Text += "7";
            }
        }

        private void numero8_Click(object sender, EventArgs e)
        {
            if (Conta.Text.Length < 11)
            {
                Conta.Text += "8";
            }
        }

        private void numero9_Click(object sender, EventArgs e)
        {
            if (Conta.Text.Length < 11)
            {
                Conta.Text += "9";
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
                Conta.Text = null;
        }

        private void Binario_Click(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(Conta.Text);
            MessageBox.Show(Convert.ToString(number, 2));
        }

        private void Hexadecimal_Click(object sender, EventArgs e)
        {
            long number = Convert.ToInt64(Conta.Text);
            MessageBox.Show(number.ToString("X"));
        }
    }
}
