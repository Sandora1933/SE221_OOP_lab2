using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace MyDataStructures
{
    public class MyStringComparer<T> : IComparer<T>  where T:MyString
    {
        public int Compare(T obj1, T obj2)
        {
            MyString str1 = obj1 as MyString;
            MyString str2 = obj2 as MyString;

            if (str1.EncryptedString.Length > str2.EncryptedString.Length)
            {
                return 1;
            }
            else if (str1.EncryptedString.Length < str2.EncryptedString.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
