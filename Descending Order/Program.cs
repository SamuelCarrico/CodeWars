using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
	public static int DescendingOrder(int num)
	{
		string numString = num.ToString();
		char[] charArray = numString.ToCharArray();
		Array.Sort<char>(charArray);
		Array.Reverse<char>(charArray);
		string str = new string (charArray);
		int strInt = Convert.ToInt32(str);
		return strInt;
	}

	public static void Main()
	{
		DescendingOrder(951234);
	}
}
