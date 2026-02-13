using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prob2
    {
        static void Main()
        {
            Console.WriteLine("Enter the sentance");
            string s = Console.ReadLine();
            s = s.ToLower();
            StringBuilder sen = new StringBuilder();

            foreach (char c in s)
            {
                if(char.IsLetterOrDigit(c))
                {
                    sen.Append(c); 
                }
            }

            
            int left = 0;
            int right = sen.Length - 1;
            bool palindrome = true;

            while(left < right)
            {
                if (sen[left] != sen[right])
                {
                    palindrome = false;
                    break;
                }
                left++;
                right--;
            }
            if (palindrome)
            {
                Console.WriteLine("Yes the sentance is palindrome");
            }
            else
            {
                Console.WriteLine("No the sentance is not a palindrome");
            }
        }
    }
}
