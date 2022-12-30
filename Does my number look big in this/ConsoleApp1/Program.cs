/*
Does my number look big in this? - https://www.codewars.com/kata/5287e858c6b5a9678200083c/train/csharp
    
A Narcissistic Number (or Armstrong Number) is a positive number which is the sum of its own digits, each raised to the power of the number of digits in a given base. In this Kata, we will restrict ourselves to decimal (base 10).

For example, take 153 (3 digits), which is narcisstic:

1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153

and 1652 (4 digits), which isn't:

1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938

The Challenge:

Your code must return true or false (not 'true' and 'false') depending upon whether the given number is a Narcissistic number in base 10. This may be True and False in your language, e.g. PHP.

    Error checking for text strings or other invalid inputs is not required, only valid positive non-zero integers will be passed into the function.
    */


//Math.Pow didn't work in CodeWars
static int Pow(int value, int exp)
{
    int result = value;
    for (int i = 1; i < exp; i++)
    {
        result *= value;
    }
    Console.WriteLine(result);
    Console.WriteLine(Math.Pow(value, exp));
    return result;
}

static bool Narcissistic(int value)
{
    int sum = 0;
    char[] ch = value.ToString().ToCharArray();
    int[] nbs = new int[ch.Length];
    
    for (int i = 0; i < ch.Length; i++)
    {
        nbs[i] = (int)char.GetNumericValue(ch[i]);
        sum += Pow(nbs[i], ch.Length);
    }
    return Console.log((sum == value));
}


Pow(5, 3);
// Narcissistic(408);