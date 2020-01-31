using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpraktika
{
    class Class1 : Interface
    {
        private int[] a;

        public string Name
        {
            get
            {
                return typeof(Class1).Name + " " + a.Length;
            }
        }

        public int this[int index]
        {
            get
            {
                if ((index < 0) || (index >= a.Length))
                {
                    throw new IndexOutOfRangeException();
                }
                return a[index];
            }
        }

        public string method1()
        {
            int res = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 2)
                {
                    res++;
                }
            }
            return res.ToString();
        }

        public string method1(string num)
        {
            string res = "";
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] > 0 && Convert.ToInt32(num) % a[i] == 0)
                {
                    res += a[i] + " ";
                }
            }
            return res;
        }

        public Class1(int size)
        {
            Random r = new Random();
            if (size < 10)
            {
                throw new Menshe10Exception();
            }

            a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = r.Next(-10, 11);
            }
        }

        public override string ToString()
        {
            string res = "";
            foreach (int i in a)
            {
                res += i + " ";
            }
            return res;
        }
    }
}
