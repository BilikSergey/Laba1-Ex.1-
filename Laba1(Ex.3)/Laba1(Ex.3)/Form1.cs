using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba1_Ex._2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var p = new Pen(Color.Black, 1);
            e.Graphics.DrawLine(p, 10, 10, 10, 100);
            e.Graphics.DrawLine(p, 200, 100, 200, 10);
            e.Graphics.DrawLine(p, 200, 100, 10, 100);
            e.Graphics.DrawLine(p, 200, 10, 10, 10);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseLeave += panel1_MouseLeave;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked) panel1.BackColor = Color.Red;
            else if (checkBox2.Checked) panel1.BackColor = Color.Yellow;
            else if (checkBox3.Checked) panel1.BackColor = Color.Blue;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }       
    }
}
