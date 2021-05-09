using System;
using System.Collections;
using static System.Console;

namespace Reversed_Strings
{
    class Program
    {
          public static string Solution(string str) 
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);    
        }


        static void Main(string[] args)
        {
           Solution("Try");
        }
    }
}
