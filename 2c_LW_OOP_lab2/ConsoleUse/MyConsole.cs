using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MyClassLibrary;
using MyDataStructures;

namespace ConsoleUse
{
    public class MyConsole
    {

       public void ShowMenu(MyDeque<MyString> myStrings)
        {
            Console.Clear();

            Console.WriteLine("Welcome! \n");
            Console.WriteLine("Here you can work with deque collection of Encrypted strings");
            Console.WriteLine("1. Display the whole collection");
            Console.WriteLine("2. Open a disc with string");
            Console.WriteLine("3. Add an element to the end of collection");
            Console.WriteLine("4. Add an element to the beginning of the collection");
            Console.WriteLine("5. Remove an element from the end of collection");
            Console.WriteLine("6. Remove an element from the beginning of the collection \n");

            Console.WriteLine("0. Exit");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    ShowWholeCollection(myStrings);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Print a disc");
                    char choiceD = Convert.ToChar(Console.ReadLine());

                    ShowDiscElement(myStrings, choiceD);

                    Console.WriteLine("\nDo you want to see Decrypted string?");

                    Console.WriteLine("1. Yes \n0. Return to main menu");
                    char choiceDecr = Convert.ToChar(Console.ReadLine());

                    if (choiceDecr == '1')
                    {
                        Console.WriteLine("Print password");
                        string pass = Console.ReadLine();

                        string ans = myStrings.GetDiscElement(choiceD).GetMainString(pass);
                        Console.WriteLine(ans);

                        Console.WriteLine("0. Return to main menu");

                        char choiceEx = Convert.ToChar(Console.ReadLine());

                        if (choiceEx == '0')
                            ShowMenu(myStrings);
                        else
                        {
                            Console.WriteLine("Wrong option!");
                            Thread.Sleep(1200);
                            ShowMenu(myStrings);
                        }
                    }
                    else if (choiceDecr == '0')
                    {
                        ShowMenu(myStrings);
                    }
                    else
                    {
                        Console.WriteLine("Wrong response!");
                        ShowMenu(myStrings);
                        Thread.Sleep(1200);
                    }
                }

                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Adding to the end of the collection : \n");
                    Console.WriteLine("Enter a new string");
                    string inString = Console.ReadLine();

                    Console.WriteLine("Enter a password for this string");
                    string inPassword = Console.ReadLine();

                    ShowAddToEnd(myStrings, inString, inPassword);
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Adding to the beginning of the collection : \n");
                    Console.WriteLine("Enter a new string");
                    string inString = Console.ReadLine();

                    Console.WriteLine("Enter a password for this string");
                    string inPassword = Console.ReadLine();

                    ShowAddToStart(myStrings, inString, inPassword);
                }
                else if (choice == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Removing from the end of the collection : \n");

                    ShowRemoveFromEnd(myStrings);
                }
                else if (choice == 6)
                {
                    Console.Clear();
                    Console.WriteLine("Removing from the beginning of the collection");

                    ShowRemoveFromStart(myStrings);
                }
                else if (choice == 0)
                {
                    Exit();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public void ShowWholeCollection(MyDeque<MyString> myStrings)
        {
            Console.Clear();

            foreach (MyString str in myStrings)
            {
                Console.WriteLine(str.EncryptedString);
                Thread.Sleep(700);
            }

            Console.WriteLine("\n0. Return to main menu");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
                ShowMenu(myStrings);
            else
            {
                Console.WriteLine("Wrong option");
                Thread.Sleep(1500);
                ShowMenu(myStrings);
            }
        }

            // From MyString -> GetDiscElement

        public void ShowDiscElement(MyDeque<MyString> myStrings, char disc)
        {
            Console.Clear();

            MyString Aim = myStrings.GetDiscElement(disc);

            Console.WriteLine($"Disc {disc} contains : " + Aim.EncryptedString);
        }

        

        public void ShowAddToEnd(MyDeque<MyString> myStrings, string str, string password)
        {
            Console.WriteLine($"The string was added to the collection successfully!");
            myStrings.AddToLast(new MyString(str, password));
            Thread.Sleep(1000);
            ShowMenu(myStrings);
        }

        public void ShowAddToStart(MyDeque<MyString> myStrings, string str, string password)
        {
            Console.WriteLine("The string was added to the collection successfully!");
            myStrings.AddToFirst(new MyString(str, password));
            Thread.Sleep(1000);
            ShowMenu(myStrings);
        }

        public void ShowRemoveFromEnd(MyDeque<MyString> myStrings)
        {
            Console.WriteLine("The string was removed from the collection successfully");
            myStrings.RemoveLast();
            Thread.Sleep(1200);
            ShowMenu(myStrings);
        }

        public void ShowRemoveFromStart(MyDeque<MyString> myStrings)
        {
            Console.WriteLine("The string was removed from the collection successfully");
            myStrings.RemoveFirst();
            Thread.Sleep(1200);
            ShowMenu(myStrings);
        }

        public void Exit()
        {
            Environment.Exit(1);
        }
    }
}
