using System;
using System.Linq;
using System.Collections.Generic;

namespace Shortest_Word
{
/*
Simple, given a string of words, return the length of the shortest word(s).
String will never be empty and you do not need to account for different data types.
*/

    class Program
    {   
        public static int FindShort(string s)
            {

                string[] wordList = s.Split(' ');
                List<string> newList = wordList.ToList();

                string min = newList.Min();
                Console.WriteLine(min);
                newList.
                return min.Length;

                

                
               
            }    
        static void Main(string[] args)
        {
            FindShort("string is wonderful abraca");
        }
    }
}
