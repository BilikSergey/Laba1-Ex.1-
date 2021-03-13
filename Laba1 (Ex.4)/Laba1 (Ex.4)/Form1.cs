using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba1__Ex._4_
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
        int lCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(
               fontFamily,
               10,
               FontStyle.Bold,
               GraphicsUnit.Pixel);

            lCount++;            
            Label lbl = new Label();
            lbl.Text = "Label" + lCount.ToString();
            lbl.Location = new Point(10, 10 + 30 * (lCount - 1));
            this.Controls.Add(lbl);
            lbl.Font = font;
        }
    }
}
