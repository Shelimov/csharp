using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void removeSelected(ListBox box)
        {
            for (int i = 0, l = box.SelectedItems.Count; i < l; i++)
            {
                box.Items.Remove(box.SelectedItems[0]);
            }
        }
        private void moveSelected(ListBox from, ListBox to)
        {
            for (int i = 0, l = from.SelectedItems.Count; i < l; i++)
            {
                to.Items.Add(from.SelectedItems[i]);
            }
            removeSelected(from);
        }
        private void selectAll(ListBox box)
        {
            for (int i = 0, l = box.Items.Count; i < l; i++)
            {
                box.SetSelected(i, true);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            moveSelected(listBox2, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSelected(listBox1, listBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectAll(listBox2);
            moveSelected(listBox2, listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectAll(listBox1);
            moveSelected(listBox1, listBox2);
        }
    }
}
