using System;

namespace DataStructures
{
    class Program
    {

        static void ConsoleWriteLine(double data)
        {
            Console.WriteLine(data);
        }
        static void Main(string[] args)
        {
            //Action<bool> print = data => Console.WriteLine(data);
            //Func<double, double> square = d => d * d;
            //Func<double, double, double> add = (d, e) => d + e ;
            //Predicate<double> isLessThanTen = d => d < 10;
            //print(isLessThanTen(square(add(3, 5))));

           


            
            //var buffer = new Buffer<double>();
            var buffer = new CircularBuffer<double>(capacity: 3);
            buffer.ItemDiscarded += ItemDiscarded;
            ProcessInput(buffer);

            //var consoleOut = new Printer<double>(ConsoleWriteLine);

            Converter<double, DateTime> converter = d => new DateTime(2010, 1, 1).AddDays(d);
            

            buffer.Dump(data => Console.WriteLine(data));
            //var asInts = buffer.AsEnumerableOf<double, int>();

            //foreach (var item in asInts)
            //{
            //    Console.WriteLine(item);
            //}

            ProcessBuffer(buffer);
            
        }

        private static void ItemDiscarded(object sender, ItemDiscardedEventArgs<double> e)
        {
            Console.WriteLine($"Buffer Full. Discarding {e.ItemDiscarded}.  New Item is {e.NewItem}");
        }

        private static void ProcessBuffer(IBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);
        }

        private static void ProcessInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }
    }
}
