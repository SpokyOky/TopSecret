using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPpraktika
{
    public partial class Form1 : Form
    {
        Class1 cl = new Class1();
         
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            textBoxArray.Text = cl.Size(Convert.ToInt32(textBoxSize.Text));
        }

        private void buttonMethod1_Click(object sender, EventArgs e)
        {
            textBoxMethod.Text = cl.m1();
        }

        private void buttonMethod2_Click(object sender, EventArgs e)
        {
            textBoxMethod.Text = cl.m2(textBox1.Text);
        }
    }
}
