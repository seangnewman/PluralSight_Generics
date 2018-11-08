using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tips
{
    class Program
    {

        public enum Steps
        {
            Step1, 
            Step2, 
            Step3
        }
        static void Main(string[] args)
        {

            //var input = "Step1";

            //// var value = (Steps)Enum.Parse(typeof(Steps), input);
            //var value = input.ParseEnum<Steps>();
            //Console.WriteLine(value);


            var numbers = new double[] { 1, 2, 3, 4, 5, 6};
            var result = SampledAverage(numbers);
            Console.WriteLine(result);

        }

        private static object SampledAverage(double[] numbers)
        {
            var count = 0;
            var sum = 0.0;
            for (int i = 0; i < numbers.Length; i+=2)
            {
                sum += numbers[i];
                count += 1;

            }

            return sum / count;
        }
    }
}
