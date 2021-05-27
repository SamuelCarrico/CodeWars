using System;
using System.Linq;
/*
Usually when you buy something, you're asked whether your credit card number, 
phone number or answer to your most secret question is still correct. 
However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

Your task is to write a function maskify, which changes all but the last four characters into '#'.
*/


namespace Credit_Card_Mask
{
    class Program
    {

          public static string Maskify(string cc)
        {
            string sharp = string.Empty;
            int index = 0;
            char[] ccArray = cc.ToCharArray();


            if(cc.Length <= 4)
            {
                return cc;
            }
            else
            {
                string[] stringArray = new string[cc.Length-4];
                for(int i = 0; i < cc.Length-4; i++)
                {                
                    stringArray.SetValue("#",i);
                                                                              
                }
                    int numberOfChar = ccArray.Length;
                    string newString = cc.Remove(index, numberOfChar-4);
                    string s = string.Concat(stringArray);
                    Console.WriteLine(s + newString);  
                
                
                return s + newString;
            }
        }

        static void Main(string[] args)
        {
            Maskify("111");
        }
    }
}
