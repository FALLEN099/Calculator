﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != String.Empty && txtB.Text != String.Empty)
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = a + b;
                textBox3.Text = c.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtA.Text != String.Empty && txtB.Text != String.Empty)
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = a + b;
                txtKetQua.Text = c.ToString();
            }
        }
    }
}
