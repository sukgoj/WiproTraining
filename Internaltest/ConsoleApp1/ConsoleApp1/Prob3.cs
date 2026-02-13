using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prob3
    {
        static void Main()
        {
            Console.WriteLine("Enter K value:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            bool changed = true;

            while (changed)
            {
                changed = false;

                for (int i = 0; i <= str.Length - k; i++)
                {
                    bool same = true;

                    for (int j = 1; j < k; j++)
                    {
                        if (str[i] != str[i + j])
                        {
                            same = false;
                            break;
                        }
                    }

                    if (same)
                    {
                        str = str.Remove(i, k);  // remove k characters
                        changed = true;
                        break;  // restart checking
                    }
                }
            }

            Console.WriteLine("Reduced String: " + str);
        }
    }
}
