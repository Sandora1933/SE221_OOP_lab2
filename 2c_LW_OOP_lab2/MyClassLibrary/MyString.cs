using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class MyString : IComparable
    {
        public string MainString { get; set; }
        public string EncryptedString { get; set; } 
        public string Password { get; }

        private int ShiftedCoefficient = 3; //The ASCII code difference

        public MyString(string someString, string password) 
        {
            MainString = someString;
            Password = password;

            char[] CharArray = MainString.ToCharArray();

            for (int i = 0; i < CharArray.Length; i++)
            {
                int newCode = Convert.ToChar(CharArray[i] + ShiftedCoefficient);
                CharArray[i] = Convert.ToChar(newCode);
            }

            EncryptedString = new string(CharArray);
        }

        public string GetMainString(string password)   
        {
            if (Password == password)
            {
                return "MainString : " + MainString;
            }
            else
            {
                return "The password is wrong!";
            }
        }

        public int CompareTo(object str)
        {
            MyString s = str as MyString;
            return EncryptedString.CompareTo(s.EncryptedString);
        }
    }
}
