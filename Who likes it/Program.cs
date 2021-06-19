using System;

namespace Who_likes_it
{

    /*
CodeWars

You probably know the "like" system from Facebook and other pages. 
People can "like" blog posts, pictures or other items. 
We want to create the text that should be displayed next to such an item.
Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item. 
It must return the display text as shown in the examples:

Kata.Likes(new string[0]) => "no one likes this"
Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"

    */
    class Program
    {
            public static string Likes(string[] name)
            {      
                
                string[] names = new string[name.Length];
                for(int i = 0; i < name.Length; i++)
                {
                    names.SetValue(name.GetValue(i),i);                   
                }


                int others = names.Length-2;
                if(names.Length < 0 )
                    return "no one likes this";
                else if(names.Length == 1)  
                    return ($"{names.GetValue(0)} likes this");
                else if(names.Length == 2)
                    return($"{names.GetValue(0)} and {names.GetValue(1)} likes this");
                else if(names.Length == 3)
                        return($"{names.GetValue(0)}, {names.GetValue(1)} and {names.GetValue(2)} likes this");
                else if(names.Length > 3 )
                    return($"{names.GetValue(0)}, {names.GetValue(1)} and {others} others likes this");
                else
                    return "";       
            }
        
        static void Main(string[] args)
        {
            string[] names = new string[]{"Bob", "Georges","François","Edouard","Jean"};
            Likes(names);
        }
    }
}
