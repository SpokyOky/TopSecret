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
            return "m1";
        }

        public string m1(string add)
        {
            return "m1" + add;
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
                a.Add(r.Next(10));
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
