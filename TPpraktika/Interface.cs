﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpraktika
{
    interface Interface : IComparable
    {
        string m1();
        string m1(string add);

        int this[int index]
        {
            get;
        }

        string Name { get; }
    }
}
