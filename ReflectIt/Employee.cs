﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectIt
{
    public class Employee
    {
        public string Name { get; set; }

        public void Speak<T>()
        {
            Console.WriteLine(typeof(T).Name);
        }
    }
}
