using System;

namespace MakeUpperCase
{
    class Program
    {

  public static string MakeUpperCase(string str)
        {
          str = Console.ReadLine();
          return str.ToUpper();
            
        }
          static void Main(string[] args)
        {
            Console.WriteLine(MakeUpperCase("coucou"));
        }
    }
}
