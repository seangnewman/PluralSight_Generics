using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ItemDiscardedEventArgs<T> : EventArgs
    {
        public ItemDiscardedEventArgs(T discardItem, T newItem)
        {
            ItemDiscarded = discardItem;
            NewItem = newItem;
        }
        public T ItemDiscarded { get; set; }
        public T NewItem { get; set; }
    }
}
