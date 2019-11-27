using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace MyDataStructures
{
    public class Node<T>
    {
        public T str { get; set; }
        public char disc { get; set; }
        public Node<T> next { get; set; }
        public Node<T> prev { get; set; }

        public Node(T Str)
        {
            str = Str;

            if (prev == null)
            {
                disc = 'A';
            }
            else
                disc = (char)(prev.disc + 1);
        }
    }
}
