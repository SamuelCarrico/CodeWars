using System;
using System.Linq;

namespace Disemvowel_Trolls
{
/*
Trolls are attacking your comment section!

A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

Your task is to write a function that takes a string and return a new string with all vowels removed.

For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

Note: for this kata y isn't considered a vowel.
*/
    class Program
    {

    public static string Disemvowel(string str)
    {
        char[] space = {' '};
        
        string[] strSpace = str.Split(space);
        foreach(string s in strSpace)
        {
            Console.WriteLine(s);
        }
        
        char[] listVowels = {'a', 'e', 'i', 'o', 'u'};
        string[] str2 = str.Split(listVowels);
        string str3 = string.Join(' ',str2);
        string str4 = str3.Trim(space);
        Console.WriteLine(str4);
        return str;
    }


        static void Main(string[] args)
        {
            Disemvowel("This website is for losers LOL!");
            if(Disemvowel("This website is for losers LOL!") == "Ths wbst s fr lsrs LL!")
                Console.Write("true");
            else Console.Write("false");
       }
    }
}
