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
                MessageBox.Show("LessThen10");
                Logger.Error("LessThen10");
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
                int n = r.Next(5, 11);
                int m = r.Next(5, 11);
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
                MessageBox.Show("LessThen10");
                Logger.Error("LessThen10");
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
                MessageBox.Show("IndexOutOfRange");
                Logger.Error("IndexOutOfRange");
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
                MessageBox.Show("IndexOutOfRange");
                Logger.Error("IndexOutOfRange");
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
                MessageBox.Show("IndexOutOfRange");
                Logger.Error("IndexOutOfRange");
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
                MessageBox.Show("IndexOutOfRange");
                Logger.Error("IndexOutOfRange");
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
                textBox1.Text += next(textBoxMyNum.Text) + "; ";
            }
            Logger.Info("invoke2");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() //вызов окошка с сохранением
                == System.Windows.Forms.DialogResult.OK)  //условие (если нажали ок в окне сохранения)
            {
                var filename = saveFileDialog1.FileName; //строка с именем файла
                if (File.Exists(filename)) //проверка (если файл существует (перезапись))
                {
                    File.Delete(filename); //если уже такой существует - удаляем
                }
                using (StreamWriter sw = new StreamWriter(filename)) //создаем StreamWriter для этого файла
                {
                    foreach (var i in classes) //цикл по списку обьектов
                    {
                        sw.WriteLine(i.Name + " : " + i.ToString() + //запись в файл "имя класса" : "элементы массива/списка"
                            " " + i.m1() + " " + i.m1(textBoxMyNum.Text)); //"результат первого метода" "результат второго метода"
                    }
                }
                MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); //вывод окна, если сохранение прошло успешно
            }
            Logger.Info("save"); //запись в лог о сохранении
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