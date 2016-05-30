using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reset();
        }
        private void reset()
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
        private string compute(string txt)
        {
            try
            {
                DataTable dt = new DataTable();
                return dt.Compute(txt.Replace(",", "."), "").ToString();
            }
            catch (System.Data.SyntaxErrorException)
            {
                return "Error";
            }
        }
        private bool isLastArithmetic()
        {
            return "+-*/".IndexOf(textBox1.Text[textBox1.Text.Length - 1]) != -1;
        }
        private bool isLastSeperator()
        {
            return textBox1.Text[textBox1.Text.Length - 1] == ',';
        }
        private bool isEmpty()
        {
            return textBox1.Text == "0";
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            char chr = clickedButton.Text[0];
            if (Char.IsDigit(chr))
            {
                if (isEmpty())
                    textBox1.Text = chr.ToString();
                else
                    textBox1.Text += chr;
            }
            else if ("()".IndexOf(chr) != -1)
            {
                if (isEmpty())
                    textBox1.Text = chr.ToString();
                else
                    textBox1.Text += chr;
            }
            else if (!isLastSeperator())
            {
                if (isLastArithmetic())
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1) + chr;
                else
                    textBox1.Text += chr;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // =
            if (isEmpty())
                return;
            textBox2.Text = compute(textBox1.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // <--
            if (isEmpty())
                return;
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // +-
            if (isLastArithmetic() || isEmpty() || isLastSeperator())
                return;
            Regex reMinused = new Regex(@"\(-(\d+\,?\d*)\)$"),
                  reBasic = new Regex(@"(\d+\,?\d*)$");
            if (reMinused.IsMatch(textBox1.Text))
            {
                textBox1.Text = reMinused.Replace(textBox1.Text, "$1");
            }
            else
            {
                textBox1.Text = reBasic.Replace(textBox1.Text, "(-$1)");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // .
            Regex re = new Regex(@"\d+\,[\d]*$");
            if (re.IsMatch(textBox1.Text) || isLastArithmetic())
                return;
            else
                textBox1.Text += ",";

        }
    }
}
