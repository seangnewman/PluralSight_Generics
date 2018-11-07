using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DataStructures
{
    public delegate void Printer<T>(T data);

    public static class BufferExtensions
    {

        // public static void Dump<T>(this IBuffer<T> buffer, Printer<T> print )
        public static void Dump<T>(this IBuffer<T> buffer,Action<T> print)
        {
            foreach (var item in buffer)
            {
                //Console.WriteLine(item);
                print(item);
            }
        }
        //public static IEnumerable<TOutput> AsEnumerableOf<T, TOutput>(this IBuffer<T> buffer)
        //{
        //    var converter = TypeDescriptor.GetConverter(typeof(T));
        //    foreach (var item in buffer)
        //    {
        //        var result = converter.ConvertTo(item, typeof(TOutput));
        //        yield return (TOutput)result;
        //    }

        //}

        public static IEnumerable<TOutput> Map<T, TOutput>(this IBuffer<T> buffer, 
            Converter<T, TOutput> converter)
        {

            //foreach (var item in buffer)
            //{
            //    var result =  converter(item);
            //    yield return (TOutput)result;
            //}

            return buffer.Select(c => converter(c));

        }
    }
}
