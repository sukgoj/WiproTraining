using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_p1
{
    internal class Prob2
    {
        static void Main()
        {
            string s;
            int count = 0;
            Console.WriteLine("Enter the sentance");
            s= Console.ReadLine();
            string[] words= s.Split(' ');
            foreach(string word in words )
            {
                bool palindrome = true;
                int left = 0;
                int right = word.Length - 1;
                if(word.Length > 0)
                {
                    while(left < right)
                    {
                        if(word[left] != word[right])
                        {
                            palindrome = false;
                            break;
                        }
                        left++;
                        right--;

                    }
                    if(palindrome==true)
                    {
                        count++;
                    }
                }
                    
            }
            Console.WriteLine("Total number of palindrome words are: " + count);

        }
    }
}
