using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private Label[,] Labels;
        private Color[,] Colors;
        int y, x;
        public Form1()
        {
            InitializeComponent();
            Labels = new Label[3, 3]
            {
                { label1, label2, label3 },
                { label4, label5, label6 },
                { label7, label8, label9 }
            };
            Colors = new Color[3, 3]
            {
                { Color.White, Color.Red, Color.Blue },
                { Color.Green, Color.Cyan, Color.Yellow },
                { Color.Black, Color.Brown, Color.Violet }
            };
            x = 0; y = 0;
        }
        private void resetCurrentColor()
        {
            if (x == 0 && y == 0)
                return;
            Labels[y, x].BackColor = Color.Transparent;
        }
        private void updateColor()
        {
            Labels[y, x].BackColor = Colors[y, x];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (x == 0)
                return;
            resetCurrentColor();
            x--;
            updateColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (y == 0)
                return;
            resetCurrentColor();
            y--;
            updateColor();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (y == 2)
                return;
            resetCurrentColor();
            y++;
            updateColor();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x == 2)
                return;
            resetCurrentColor();
            x++;
            updateColor();
        }
    }
}
