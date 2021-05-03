using System;
using static System.Console;
using System.Collections.Generic;

namespace Digitize
{
    class Program
    {
                public static int[] digitize(int n)
                {      
                       List<int> chiffres = new List<int>();
                       chiffres.Add(n);
                       chiffres.ToString();
                       foreach(char letters in chiffres)
                       {
                           WriteLine(letters);
                       }
                       return chiffres.ToArray();
                }

                    static void Main(string[] args)
        {
                    digitize(4);
        }
    }
}
