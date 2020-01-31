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
            int res = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    res++;
                }
            }
            return res.ToString();
        }

        public string m2(string num)
        {
            string res = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0 && a[i] > Convert.ToInt32(num))
                {
                    res += a[i] + " ";
                }
            }
            return res;
        }

        public string Size(int size)
        {
            if (size < 10)
            {
                return null;
            }

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
