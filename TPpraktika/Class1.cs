using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpraktika
{
    class Class1
    {
        private int[] a;

        public string m1()
        {
            return "m1";
        }

        public string m2()
        {
            return "m2";
        }

        public string Size(int size)
        {
            Random r = new Random();
            a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = r.Next(10);
            }

            string res = "";
            foreach (int i in a)
            {
                res += i + " ";
            }
            return res;
        }
    }
}
