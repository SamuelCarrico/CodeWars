using System;

namespace Remove_anchor_from_URL
{
    /*
    Complete the function/method so that it returns the url with anything after the anchor (#) removed.
    Examples :
    Kata.RemoveUrlAnchor("www.codewars.com#about") => "www.codewars.com"
    Kata.RemoveUrlAnchor("www.codewars.com?page=1") => "www.codewars.com?page=1"
    */
    class Program
    {

        public static string RemoveUrlAnchor(string url)
        {
            
        string[] urlRemoved = url.Split('#',0);
        foreach(string sentence in urlRemoved)
        {
            Console.WriteLine(sentence);
        }
        return url;
        }

        static void Main(string[] args)
        {
            RemoveUrlAnchor("www.codewars.com#about");
        }
    }
}
