using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = CreateCollection( typeof(List<>), typeof(Employee));
            Console.Write(employeeList.GetType().Name);
            //Console.WriteLine(employeeList.GetType().FullName);
            var genericArguments = employeeList.GetType().GenericTypeArguments;
             

            foreach (var arg in genericArguments)
            {
                Console.WriteLine($"{arg.Name}");
            }

            var employee = new Employee();
            var employeeType = typeof(Employee);
            var methodInfo = employeeType.GetMethod("Speak");
            methodInfo = methodInfo.MakeGenericMethod(typeof(DateTime));

             
            methodInfo.Invoke(employee, null);
        }

        private static object CreateCollection(Type collectionType, Type itemType)
        {

            var closedType = collectionType.MakeGenericType(itemType);
            return Activator.CreateInstance(closedType);
        }
    }
}
