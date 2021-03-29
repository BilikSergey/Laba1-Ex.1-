using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        delegate void Check();
        Check ch1;
        Check ch2;
        Check ch3;
        public Form1()
        {
            InitializeComponent();           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            { ch1 = Bt1; ch1(); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            { ch2 = Bt2; ch2(); }       
        }
        private void button3_Click(object sender, EventArgs e)
        {
            { ch3 = Bt3; ch3(); }
        }       
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка, i цього мене не позбавиш!");
            if (checkBox1.Checked) { ch1 = Bt1; ch1(); }
            if (checkBox2.Checked) { ch2 = Bt2; ch2(); }
            if (checkBox3.Checked) { ch3 = Bt3; ch3(); }
        }
        public void Bt1()
        {
            if (this.Opacity != 0.75 && this.Opacity == 1) this.Opacity = 0.75;
            else this.Opacity = 1;
        }
        private void Bt2()
        {
            if (BackColor == Color.Red && BackColor != Color.Gray) this.BackColor = System.Drawing.Color.Gray;
            else this.BackColor = System.Drawing.Color.Red;
        }
        private void Bt3()
        {
            MessageBox.Show("Hello World!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }       
    }
}
