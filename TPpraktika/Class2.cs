using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpraktika
{
    class Class2 : Interface
    {
        private List<int> a;

        public string Name
        {
            get
            {
                return typeof(Class2).Name + " " + a.Count;
            }
        }

        public string m1()
        {
            int res = 0;
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] == 0)
                {
                    continue;
                }

                if ((a[i] % 2 == 0) && (100 % a[i] == 0))
                {
                    res++;
                }
            }
            return res.ToString();
        }

        public string m1(string num)
        {
            string res = "";
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > 0 && a[i] % Convert.ToInt32(num) == 0)
                {
                    res += a[i] + " ";
                }
            }
            return res;
        }

        public int this[int index]
        {
            get
            {
                return a[index];
            }
        }

        public Class2(int size)
        {
            Random r = new Random();
            if (size < 10)
            {
                throw new LessThen10Exception();
            }

            a = new List<int>(size);
            for (int i = 0; i < size; i++)
            {
                a.Add(r.Next(-10, 11));
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

        public int CompareTo(object obj)
        {
            return new Random().Next(-1, 2);
        }
    }
}
