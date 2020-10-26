using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Model
{
    public class DuplexLinkedDeque<T>
    {
        public DuplexItem<T> Head;
        public DuplexItem<T> Tail;

        public int Count { get; private set; }

        public DuplexLinkedDeque() { }
        public DuplexLinkedDeque(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void PushBack(T data)
        {
            if(Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            item.Next = Tail;
            Tail.Previous = item;
            Tail = item;
            Count++;
        }

        public void PushFront(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            item.Previous = Head;
            Head.Next = item;
            Head = item;
            Count++;
        }

        public T PopBack()
        {
            if(Count > 0 && Tail.Next != null)
            {
                var result = Tail.Data;
                var current = Tail.Next;
                current.Previous = null;
                Tail = current;
                Count--;
                return result;
            }
            else
            {
                Count--;
                T t = ReturnEmpty();
                return t;
            }
        }

        public T PopFront()
        {
            if (Count > 0 && Head.Previous != null)
            {
                var result = Head.Data;
                var current = Head.Previous;
                current.Next = null;
                Head = current;
                Count--;
                return result;
            }
            else
            {
                Count--;
                T t = ReturnEmpty();
                return t;
            }
        }

        public T ReturnEmpty()
        {
            var result = Head != null ? Head.Data : Tail.Data;
            Head = null;
            Tail = null;
            return result;
        }

        public T PeekBack()
        {
            return Tail.Data;
        }

        public T PeekFront()
        {
            return Head.Data;
        }
    }
}
