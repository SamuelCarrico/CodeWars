using System;

namespace Price_of_Mangoes
{
    /*There's a "3 for 2" (or "2+1" if you like) offer on mangoes. 
     * For a given quantity and price (per mango), calculate the total cost of the mangoes.
     */ 

    class Program
    {
        int CalculatePrice(int quantity,int price)
        {
           int nbreGratuit = quantity - quantity / 3;
            return nbreGratuit * price;
        }


        static void Main(string[] args)
        {
            Program test = new Program();
            Console.WriteLine(test.CalculatePrice(3,3).ToString());                    
        }
    }
}
