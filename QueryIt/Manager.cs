﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryIt
{
    class Manager:Employee
    {
        public override void Dowork()
        {
            Console.WriteLine("Calling a meeting");
        }
    }
}
