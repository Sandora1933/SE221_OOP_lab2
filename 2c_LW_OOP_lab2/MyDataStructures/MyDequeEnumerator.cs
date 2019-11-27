using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructures
{
    public class MyDequeEnumerator<T> : IEnumerator<T>
    {
        MyDeque<T> deque;
        int position;

        Node<T> curr;

        public MyDequeEnumerator(MyDeque<T> otherDeque)
        {
            this.deque = otherDeque;
        }

        public bool MoveNext()
        {
            if (position < deque.Count)
            {
                curr = deque.current.next;
                deque.current = deque.current.next;
                position++;
                return true;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public object Current
        {
            get
            {
                return this.curr.str;
            }
        }

        T IEnumerator<T>.Current
        {
            get
            {
                return this.curr.str;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            this.curr = deque.head;
            this.deque.current = deque.head;
            position = -1;
        }
    }
}
