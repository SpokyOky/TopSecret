using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        Logger Logger;

        Class1 cl;

        List<Interface> classes;

        public event Deleg1 method1;
        public event Deleg2 method2;

        public Form1()
        {
            InitializeComponent();
            Logger = LogManager.GetCurrentClassLogger();
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            try
            {
                cl = new Class1(Convert.ToInt32(textBoxSize.Text));
                textBoxArray.Text = cl.ToString();
            }
            catch (LessThen10Exception ex)
            {
                MessageBox.Show("pizdec");
                Logger.Error("pizdec");
            }
        }

        private void buttonMethod1_Click(object sender, EventArgs e)
        {
            textBoxMethod.Text = cl.m1();
        }

        private void buttonMethod2_Click(object sender, EventArgs e)
        {
            textBoxMethod.Text = cl.m1(textBoxMyNum.Text);
        }

        private void buttonSetList_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();
                int n = r.Next(2, 4);
                int m = r.Next(2, 4);
                classes = new List<Interface>(n + m);
                for (int i = 0; i < n; i++)
                {
                    classes.Add(new Class1(Convert.ToInt32(textBoxSize.Text)));
                    listBox1.Items.Add(classes[i].Name);
                }
                for (int i = n; i < m + n; i++)
                {
                    classes.Add(new Class2(Convert.ToInt32(textBoxSize.Text)));
                    listBox1.Items.Add(classes[i].Name);
                }
            } catch (LessThen10Exception ex)
            {
                MessageBox.Show("pidoras");
                Logger.Error("pidoras");
            }
        }

        private void buttonFollow1_Click(object sender, EventArgs e)
        {
            try
            {
                method1 += classes[listBox1.SelectedIndex].m1;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("pidoras");
                Logger.Error("pidoras");
            }
        }

        private void buttonFollow2_Click(object sender, EventArgs e)
        {
            try
            {
                method2 += classes[listBox1.SelectedIndex].m1;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("pidoras");
                Logger.Error("pidoras");
            }
        }

        private void buttonUnfollow1_Click(object sender, EventArgs e)
        {
            try
            {
                method1 -= classes[listBox1.SelectedIndex].m1;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("pidoras");
                Logger.Error("pidoras");
            }
        }

        private void buttonUnfollow2_Click(object sender, EventArgs e)
        {
            try
            {
                method2 -= classes[listBox1.SelectedIndex].m1;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("pidoras");
                Logger.Error("pidoras");
            }
        }

        private void buttonInvoke1_Click(object sender, EventArgs e)
        {
            foreach (Deleg1 next in method1.GetInvocationList())
            {
                textBox1.Text += next() + "; ";
            }
            Logger.Info("invoke1");
        }

        private void buttonInvoke2_Click(object sender, EventArgs e)
        {
            foreach (Deleg2 next in method2.GetInvocationList())
            {
                textBox1.Text += next("her") + "; ";
            }
            Logger.Info("invoke2");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var filename = saveFileDialog1.FileName;
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (var i in classes)
                    {
                        sw.WriteLine(i.Name + " : " + i.ToString() +
                            " " + i.m1() + " " + i.m1("her"));
                    }
                }
                MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Logger.Info("save");
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            classes.Sort();
            listBox1.Items.Clear();
            foreach (var i in classes)
            {
                listBox1.Items.Add(i.Name);
            }
        }
    }
}