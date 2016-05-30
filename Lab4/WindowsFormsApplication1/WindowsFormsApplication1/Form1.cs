using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string[] toSearch = getInput();
            if (toSearch[0] == "")
                return;
            foreach (string el in toSearch)
            {
                List<string> tmp = search(el);
                foreach (string toAdd in tmp)
                {
                    if (!listBox2.Items.Contains(toAdd))
                    {
                        listBox2.Items.Add(toAdd);
                    }
                }
            }
        }
        private string[] getInput()
        {
            string str = textBox1.Text;
            return Regex.Split(str, @"\s*,\s*");
        }
        private List<string> search(string item)
        {
            List<string> list = new List<string>();
            Regex pattern = new Regex(item);
            for (int i = 0, l = listBox1.Items.Count; i < l; i++)
            {
                if (pattern.IsMatch(listBox1.Items[i].ToString()))
                    list.Add(listBox1.Items[i].ToString());
            }
            return list;
        }
    }
}
