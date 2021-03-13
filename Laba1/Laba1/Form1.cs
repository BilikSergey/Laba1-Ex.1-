using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Capture) textBox1.Text = "*****";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Capture) textBox1.Text = "+++++";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Capture) textBox1.Text = "00000";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor=Color.Chocolate;
            textBox1.Text = "Готовий до роботи";
        }
    }
}
