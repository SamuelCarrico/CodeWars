using System;
using System.Collections;
using System.Linq;

/*
Given an array of integers your solution should find the smallest integer.

For example:
Given [34, 15, 88, 2] your solution will return 2
Given [34, -345, -1, 100] your solution will return -345
You can assume, for the purpose of this kata, that the supplied array will not be empty.
*/



namespace Find_the_smallest_integer_in_the_array
{
    
    class Program
    {

    public static int FindSmallestInt(int[] args) 
    {
      return args.Min();
    }

        static void Main(string[] args)
        {
            int[] listInt = new int[]{ 2, 5, 6, 1, 88, 95, 41 };
            FindSmallestInt(listInt);
        }
    }
}
