using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace MyDataStructures
{
    public class MyDeque<T> : IEnumerable<T>
    {
        public Node<T> head;
        public Node<T> tail;
        public Node<T> current { get; set; }
        public int count { get; set; }

        public MyDeque()
        {
            count = 0;
            head = null;
            tail = null;
        }
            
        public void AddToLast(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;
                node.disc = 'A';
            }
            else
            {
                tail.next = node;
                node.prev = tail;
                node.disc = Convert.ToChar(node.prev.disc + 1);
            }

            tail = node;
            count++;
        }

        public void AddToFirst(T data)
        {
            Node<T> node = new Node<T>(data);

            Node<T> temp = head;
            node.next = temp;
            head = node;
            if (count == 0)
            {
                tail = head;
            }              
            else
            {
                temp.prev = node;
            }
                

            count++;
        }

        public T RemoveFirst()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.str;
            if (count == 1)
            {
                head = tail = null;
                //head.index = 1; //TO UNDERSTAND
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            count--;
            return output;
        }

        public T RemoveLast()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = tail.str;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
            count--;
            return output;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.str.Equals(data))
                    return true;
                current = current.next;
            }
            return false;
        }

        public T GetDiscElement(char disc)
        {
            Node<T> node = head;

            while (node.disc != disc)
            {
                node = node.next;
            }

            return node.str;
        }

        //public IEnumerator<MyString> GetEnumerator()
        //{           
        //     Node<MyString> node = head;

        //     while (node != null)
        //     {
        //         yield return node.str;
        //        node = node.next;
        //     }           
        //}

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node = head;

            while (node != null)
            {
                yield return node.str;  //String != MyString
                node = node.next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator() //ттерация по ноде хотя надо по коллекции
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //IEnumerable<T> IEnumerable<T>.GetEnumerator()
        //{
        //    Node<MyString> node = head;

        //    while (node != null)
        //    {
        //        yield return node.str;
        //        node = node.next;
        //    }
        //}

    }
}
