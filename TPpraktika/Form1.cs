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
    public delegate string Deleg1();
    public delegate string Deleg2(string add);

    public partial class Form1 : Form
    {
        Class1 cl;

        List<Interface> classes;

        public event Deleg1 method1;
        public event Deleg2 method2;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            cl = new Class1(Convert.ToInt32(textBoxSize.Text));
            textBoxArray.Text = cl.ToString();
        }

        private void buttonMethod1_Click(object sender, EventArgs e)
        {
            textBoxMethod.Text = cl.m1();
        }

        private void buttonMethod2_Click(object sender, EventArgs e)
        {
            textBoxMethod.Text = cl.m1(textBoxSize.Text);
        }

        private void buttonSetList_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int n = r.Next(2, 4);
            int m = r.Next(2, 4);
            classes = new List<Interface>(n + m);
            
            for (int i = 0; i < n; i++)
            {
                classes.Add(new Class1(Convert.ToInt32(textBoxSize.Text)));
                listBox1.Items.Add(classes[i].Name);
                listBox2.Items.Add(classes[i].ToString());
            }
            for (int i = n; i < m + n; i++)
            {
                classes.Add(new Class2(Convert.ToInt32(textBoxSize.Text)));
                listBox1.Items.Add(classes[i].Name);
                listBox2.Items.Add(classes[i].ToString());
            }
        }

        private void buttonFollow1_Click(object sender, EventArgs e)
        {
            method1 += classes[listBox1.SelectedIndex].m1;
        }

        private void buttonFollow2_Click(object sender, EventArgs e)
        {
            method2 += classes[listBox1.SelectedIndex].m1;
        }

        private void buttonUnfollow1_Click(object sender, EventArgs e)
        {
            method1 -= classes[listBox1.SelectedIndex].m1;
        }

        private void buttonUnfollow2_Click(object sender, EventArgs e)
        {
            method2 -= classes[listBox1.SelectedIndex].m1;
        }

        private void buttonInvoke1_Click(object sender, EventArgs e)
        {
            foreach (Deleg1 next in method1.GetInvocationList())
            {
                textBox1.Text += next() + "; ";
            }
        }

        private void buttonInvoke2_Click(object sender, EventArgs e)
        {
            foreach (Deleg2 next in method2.GetInvocationList())
            {
                textBox1.Text += next("her") + "; ";
            }
        }
    }
}
