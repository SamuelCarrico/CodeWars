using System;

/*
Write a method that takes one argument as name and then greets that name, capitalized and ends with an exclamation point.

Example:

"riley" --> "Hello Riley!"
"JACK"  --> "Hello Jack!"
*/

namespace Greet_Me
{
    class Program
    {
        public static string Greet(string name)
        {
            string last = name.Substring(1);
            string first = name.Remove(1);
            string firstToUpper = first.ToUpper();
            string lastToLower = last.ToLower();
            Console.WriteLine($"Hello {firstToUpper}{lastToLower}");
            return first;
        }

        static void Main(string[] args)
        {
           Greet("baCK");
        }
    }
}
