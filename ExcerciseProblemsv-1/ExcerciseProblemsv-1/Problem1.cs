using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseProblemsv_1
{
    internal class Problem1
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                // Reverse alternate words (odd index words)
                if (i % 2 == 1)
                {
                    char[] chars = words[i].ToCharArray();
                    Array.Reverse(chars);
                    words[i] = new string(chars);
                }
            }

            string result = string.Join(" ", words);

            Console.WriteLine("Output:");
            Console.WriteLine(result);
        }
    }
}
