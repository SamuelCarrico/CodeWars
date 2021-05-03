using System;


/*
The wide mouth frog is particularly interested in the eating habits of other creatures.
He just can't stop asking the creatures he encounters what they like to eat. 
But then he meet the alligator who just LOVES to eat wide-mouthed frogs!
When he meets the alligator, it then makes a tiny mouth.
Your goal in this kata is to create complete the mouth_size method this method take one argument animal which corresponds 
to the animal encountered by frog. If this one is an alligator (case insensitive) return small otherwise return wide.
*/

namespace The_Wide_Mouthed_frog
{
    class Program
    {

        public static string MouthSize(string animal)
        {       
            if(animal != "alligator")
            {
                return "wide";
            }
            else return "small";
        }       

        static void Main(string[] args)
        {

        }
    }
}
