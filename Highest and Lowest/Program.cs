using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

/*
you are given a string of space separated numbers, and have to return the highest and lowest number.
All numbers are valid Int32, no need to validate them.
There will always be at least one number in the input string.
Output string must be two numbers separated by a single space, and highest number is first.
*/

namespace Highest_and_Lowest
{
    class Program
    {

           
         public static string HighAndLow(string numbers)
         {                       
          //  List<string> listStringNumber = new List<string>();
          //  listStringNumber.Add(new string(numbers));           
            
            
            char[] separators = new char[] { ' ', '.' };
            string[] subs = numbers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            
            Array.Sort(subs);
            
            double[] doubleArray = new double[subs.Length];
            double max = doubleArray.First();
            double min = doubleArray.Last();
            
            for(int i = 0; i < subs.Length; i++)
            {       
                doubleArray[i] = Convert.ToDouble(subs[i]);                                
            }
            Array.Sort(doubleArray);
            
            WriteLine(doubleArray.Last() + " " + doubleArray.First());
            return doubleArray.Last().ToString() + " " + doubleArray.First().ToString();
            }                    


        static void Main(string[] args)
        {
            HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4");
            
        }
    }
}
