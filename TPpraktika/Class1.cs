﻿using System;
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
                return a[index];
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

        public Class1(int size)
        {
            Random r = new Random();
            if (size < 10)
            {
                size = r.Next(10, 20);
            }

            a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = r.Next(10);
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
