using System;
using System.Collections.Generic;
using static System.Console;



/*
Return the number (count) of vowels in the given string.
We will consider a, e, i, o, u as vowels for this Kata (but not y).
The input string will only consist of lower case letters and/or spaces.
*/

namespace Vowel_Count
{
    class Program
    {
    public static int GetVowelCount(string str)
    {
        int index = 0;
        int vowelCount = 0;
        char[] vowel = str.ToCharArray();
        
        foreach(char v in vowel)
            vowel.SetValue(v,index);               
            
        for(int i = 0; i < vowel.Length; i++)
        {            
            if((char)vowel.GetValue(i) == 'a' || (char)vowel.GetValue(i) == 'e' || (char)vowel.GetValue(i) == 'i' || (char)vowel.GetValue(i) == 'o' || (char)vowel.GetValue(i) == 'u')
            {
                vowelCount++;
            }
        }   
        //WriteLine(vowel.GetValue(5));             
        WriteLine(vowelCount);
        return vowelCount;        
    }


        static void Main(string[] args)
        {
            GetVowelCount(" ae io u ");
        }
    
    }
}

