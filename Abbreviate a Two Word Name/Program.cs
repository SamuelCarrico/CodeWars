using System;
using System.Collections.Generic;
using static System.Console;

namespace Abbreviate_a_Two_Word_Name
{

    /*
    Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.
    The output should be two capital letters with a dot separating them.
    It should look like this:
    Sam Harris => S.H
    Patrick Feeney => P.F
    */

    class Program
    {

        public static string AbbrevName(string name)
        {          
           
            return ""; // firstPart + "." + LastPart;
        }

        static void Main(string[] args)
        {
            AbbrevName("Gerard Majax");
        }
    }
}
