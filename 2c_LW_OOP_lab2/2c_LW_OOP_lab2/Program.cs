using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;
using MyDataStructures;
using ConsoleUse;

namespace _2c_LW_OOP_lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDeque<MyString> myStrings = new MyDeque<MyString>();

            MyString str1 = new MyString("FirstString", "111");
            myStrings.AddToLast(str1);

            MyString str2 = new MyString("SecondString", "222");
            myStrings.AddToLast(str2);

            MyString str3 = new MyString("ThirdString", "333");
            myStrings.AddToLast(str3);

            MyString str4 = new MyString("FourthString", "444");
            myStrings.AddToLast(str4);

            MyString str5 = new MyString("FifthString", "555");
            myStrings.AddToLast(str5);

            MyConsole console = new MyConsole();
            console.ShowMenu(myStrings);           

            //foreach (MyString str in myStrings)
            //{
            //    Console.WriteLine(str.GetEncryptedString() + "\n");
            //}

            //Console.WriteLine("------------------");

            //foreach (MyString ostr in myStrings)
            //{
            //    Console.WriteLine(ostr.GetMainString("11") + "\n");
            //}

            //Console.WriteLine("------------------");

            //MyConsole.ShowIndexElement(myStrings, 2);
        }
    }
}
