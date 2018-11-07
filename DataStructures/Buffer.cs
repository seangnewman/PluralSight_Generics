using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataStructures
{
    public class Buffer<T> : IBuffer<T>
    {
        protected Queue<T> _queue = new Queue<T>();

        public virtual bool IsEmpty => _queue.Count == 0;
        //{
        //    get { return _queue.Count == 0; }
        //}

        public virtual void Write(T value) => _queue.Enqueue(value);
        //{
        //    _queue.Enqueue(value);
        //}

        public virtual T Read() => _queue.Dequeue();
        //{
        //    return _queue.Dequeue();
        //}

        //public IEnumerable<TOutput> AsEnumerableOf<TOutput>()
        //{
        //    var converter = TypeDescriptor.GetConverter(typeof(T));
        //    foreach (var item in _queue)
        //    {
        //        var result = converter.ConvertTo(item, typeof(TOutput));
        //        yield return (TOutput)result;
        //    }


        //}

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _queue)
            {
                // ...
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
