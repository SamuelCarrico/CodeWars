using System;



/*
John wants to decorate the walls of a room with wallpaper. He wants a fool-proof method for getting it right.

John knows that the rectangular room has a length of l meters, a width of w meters, a height of h meters. 
The standard width of the rolls he wants to buy is 52 centimeters. 
The length of a roll is 10 meters. 
He bears in mind however, that it’s best to have an extra length of wallpaper handy in case of mistakes or miscalculations 
so he wants to buy a length 15% greater than the one he needs.
Last time he did these calculations he got a headache, so could you help John?

Task
Your function wallpaper(l, w, h) should return as a plain English word in lower case the number of rolls he must buy.

Example:
wallpaper(4.0, 3.5, 3.0) should return "ten"
wallpaper(0.0, 3.5, 3.0) should return "zero"
*/



namespace Easy_wallpaper
{
    class Program
    {

        string WallPaper(double l, double w, double h)
        {           
           double widthRoll = 0.52;
           double lengthRoll = 10;
           double areaPiece =  l*w*h;
           double rollsArea = widthRoll*lengthRoll;
           double rolls = areaPiece/rollsArea;
           double rollsNumber = rolls + rolls*15/100;
           int ceiling = (int)Math.Ceiling(rollsNumber);

            if(areaPiece <= 0)
            {
                return "zero";
            }
            else if(ceiling == 1)
            {
                return "one";
            }
            else if(ceiling == 2)
            {
                return "two";
            }
            else if(ceiling == 3)
            {
                return "three";
            }
            else if(ceiling == 4)
            {
                return "four";
            }
            else if(ceiling == 5)
            {
                return "five";
            }
            else if(ceiling == 6)
            {
                return "six";
            }
            else if(ceiling == 7)
            {
                return "seven";
            }
            else if(ceiling == 8)
            {
                return "eight";
            }
            else if(ceiling == 9)
            {
                return "nine";
            }
            else if(ceiling == 10)
            {
                return "ten";
            }
            else if(ceiling == 11)
            {
                return "eleven";
            }
            else if(ceiling == 12)
            {
                return "twelve";
            }
            else if(ceiling == 13)
            {
                return "thirteen";
            }
            else if(ceiling == 14)
            {
                return "fourteen";
            }
            else if(ceiling == 15)
            {
                return "fifteen";
            } 
            else if(ceiling == 16)
            {
                return "sixteen";
            }
            else if(ceiling == 17)
            {
                return "seventeen";
            }
            else if(ceiling == 18)
            {
                return "eighteen";
            }
            else if(ceiling == 19)
            {
                return "nineteen";
            } 
            else if(ceiling == 20)
            {
                return "twenty";
            }                                                                 
            else return "zero";                                   
        }

          


            static void Main(string[] args)
            {
                Program p = new Program();
                p.WallPaper(2.0,1.0,5.0);               
            }
        
    }
}

    

