using System;
using System.Linq;

/*
Sum all the numbers of the array (in F# and Haskell you get a list) except the highest and the lowest element (the value, not the index!).
(The highest/lowest element is respectively only one element at each edge, even if there are more than one with the same value!)

Example:
{ 6, 2, 1, 8, 10 } => 16
{ 1, 1, 11, 2, 3 } => 6
*/

namespace Sum_without_highest_and_lowest_number
{

    class Program
    {
        public static int Sum(int[] numbers)
        {
            int min = numbers.Min();
            int max = numbers.Max();
            string message = new string("Error");
            
            if(numbers.Length == 1)
            {
                return 0;
            }  
            else  if(numbers.Length < 1 || numbers == null)
            {
                throw new NullReferenceException(message);
            }
            Console.WriteLine(numbers.Sum()-min-max);
            return numbers.Sum()-min-max;
        }
        

        static void Main(string[] args)
        {
            int[] arrayInt = new int[]{};
            Sum(arrayInt);
        }
    }
}
