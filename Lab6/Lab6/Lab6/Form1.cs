using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar) || Char.IsLetter(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            for (int i = 0, l = listBox1.Items.Count; i < l; i++)
            {
                if (listBox1.GetSelected(i))
                {
                    listBox1.SetSelected(i, false);
                }
                if (listBox1.Items[i].ToString().ToLower()[0] == textBox1.Text.ToLower()[0])
                {
                    listBox1.SetSelected(i, true);
                }
            }
        }
    }
}
