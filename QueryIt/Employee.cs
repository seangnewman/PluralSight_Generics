using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryIt
{
    class Employee:Person, IEntity
    {
        public int Id { get; set; }

        public virtual void Dowork()
        {
            Console.WriteLine("Doing Real Work!");
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
