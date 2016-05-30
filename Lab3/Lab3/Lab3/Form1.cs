using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            update(Int32.Parse(textBox1.Text));
        }
        private void update(int n)
        {
            int i;
            if (n % 2 == 0)
            {
                i = 2;
            }
            else
            {
                i = 1;
            }
            for (; i <= n; i += 2)
            {
                label1.Text += i.ToString();
                if (i != n)
                {
                    label1.Text += "*";
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && !Char.IsControl(key))
            {
                e.Handled = true;
            }
        }
    }
}
