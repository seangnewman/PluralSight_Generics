using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectIt
{
    class Programam
    {
        static void Main(string[] args)
        {
            var departments = new DepartmentCollection();


            departments.Add("Sales", new Employee { Name = "Tyler" })
                       .Add("Sales", new Employee { Name = "Taylor" })
                       .Add("Engineering", new Employee { Name = "Sean" })
                       .Add("Engineering", new Employee { Name = "Connor" })
                       .Add("Engineering", new Employee { Name = "Cody" });
                        

            

            foreach (var department in departments)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department.Value)
                {
                    Console.WriteLine($"\t{employee.Name}");
                }
            }
             



        }
    }
}
