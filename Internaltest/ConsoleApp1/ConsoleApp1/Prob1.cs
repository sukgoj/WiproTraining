using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prob1
    {
        static void Main()
        {
            Console.WriteLine("Enter the sentence: ");
            string s = Console.ReadLine();

            char result = '$';
            bool found = false;

            
            for (int i = 0; i < s.Length; i++)
            {
                bool repeat = false;

                // Compare with all other characters
                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j && s[i] == s[j])
                    {
                        repeat = true;
                        break;
                    }
                }

                // If character is not repeating
                if (!repeat && s[i] != ' ')
                {
                    result = s[i];
                    found = true;
                    break;
                }
            }
            if (result == '$')
            {
                Console.WriteLine($"There is no non repeating charcters: " + result);

            }
            else
            {
                Console.WriteLine($"First non-repeating character for the sentance {s} is: " + result);
            }

                
        }
    }
}
