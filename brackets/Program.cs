using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brackets
{
    class Program
    {
        static void Main()
        {
            string s;
            while ((s = Console.ReadLine()) != null)
            {
                int brackets = 0;
                int i;
                for (i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        brackets++;
                    }
                    else if (s[i] == ')' && --brackets < 0)
                    {
                        break;
                    }
                }
                Console.WriteLine(brackets);// if the brackets are arranged correctly the top line displays 0 if not then -1
                Console.WriteLine(i);// the bottom line shows the number of correctly placed brackets
            }
        }
    }
}