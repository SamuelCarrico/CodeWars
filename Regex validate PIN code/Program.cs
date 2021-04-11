using System;

namespace Regex_validate_PIN_code
{
    class Program
    {
        /*ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
        If the function is passed a valid PIN string, return true, else return false.
        */
       
       

        public static bool ValidatePin(string pin)
        {
            if (pin.Length != 4 || pin.Length != 6)
                return false;
                      
            else 
            { 
                pin.ToCharArray();
                foreach (int digits in pin)
                {
                    Console.WriteLine(digits);

                }
                
            }
            return true;
        }
            static void Main(string[] args)
        {
            
            if(ValidatePin("12222234") == true)
            {             
                Console.WriteLine("Vrai");
                typeof(int);
            }
            else Console.WriteLine("Faux");
        }
    }
}
