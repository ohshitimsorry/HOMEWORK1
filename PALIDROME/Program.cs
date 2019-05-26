using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PALIDROME
{
    public class Palindrom
    {
        public static string Reverser(string a)
        {
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static string Palindromer(string x)
        {
            string y = Reverser(x);
            Console.WriteLine(y);
            if (Equals(x, y))
                return "Palindrome";
            else
                return "Not palindrome";
        }
        public static void Main()
        {
            Console.Title = "Enter:";
            Console.WriteLine("Enter");
            string pattern = @"\.+?|\,+?|\ +?|\-+?|\:+?";
            string input = Console.ReadLine();
            string str = input.ToLower();
            str = (Regex.Replace(str, pattern, string.Empty));
            Console.WriteLine(input + " - " + Palindromer(str));
            Console.WriteLine();
            Console.ReadLine();
        }  
    }
}
