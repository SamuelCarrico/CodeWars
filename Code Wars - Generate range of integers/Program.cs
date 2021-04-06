using System;
using System.Collections;
using System.Collections.Generic;

namespace Code_Wars___Generate_range_of_integers
{


    /*Implement a function named generateRange(min, max, step), 
    * which takes three arguments and generates a range of integers from min to max, with the step. 
    * The first integer is the minimum value, the second is the maximum of the range and the third is the step. (min < max)     
    */

    class Program
    {

        int[] GenerateRange(int min, int max, int step)
        {
            int[] tableau = new int[((max - min) / step) + 1];
            //Console.WriteLine(tableau.Length);
            // min = 0; max = 10; step = 2
            // tab[0] = min = 0
            // tab[] = > [0,2,4,6,8,10]
            tableau[0] = min;

            for (int i = 1; i < tableau.Length; i++)
            {
                tableau[i] = step + tableau[i - 1];
                Console.WriteLine(tableau[i]);
            }

            return tableau;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.GenerateRange(0, 10, 2);

        }
    }
}

