using System;
using static System.Math;

namespace Will_there_be_enough_space
{
    class Program
    {
  public static int Enough(int cap, int on, int wait)
  {
      if((wait+on) > cap)
        {
        return Abs(cap-(wait+on));
        }
      else return 0;
    }



        static void Main(string[] args)
        {

        }
    }
}
