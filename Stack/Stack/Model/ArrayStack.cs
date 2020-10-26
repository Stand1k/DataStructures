using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Model
{
    public class ArrayStack<T>
    {
        T[] items;

        public int Count => items.Length;
        private int current = -1;
        private readonly int size = 10;

        public ArrayStack(int size = 10)
        {
            items = new T[size];
            this.size = size;
        }

        public ArrayStack(T data, int size = 10) : this(size)
        {
            items[0] = data;
            current = 0;
        }

        public void Push(T data)
        {
            if(current < size - 1)
            {
                current++;
                items[current] = data;
            }
            else
            {
                throw new StackOverflowException("Stack overflow");
            }
        }

        public T Pop()
        {
            if(current >= 0)
            {
                var item = items[current];
                //items[current] = default(T);
                current--;
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (current >= 0)
            {
                return items[current];;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }
    }
}
