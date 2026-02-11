using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_p1
{
    internal class Array4
    {
        public void Show()
        {
            int[] a = new int[10];
            int n;
            Console.WriteLine("enter size of array");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter {0} elements to array", n);
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int x;
            Console.WriteLine("Enter the element to search");
            x = Convert.ToInt32(Console.ReadLine());
            bool b = false;
            for(int i =0;i<n;i++)
            {
                if (x == a[i])
                {
                    Console.WriteLine("{0} Element found at" + i, n);
                    b= true;
                    break;
                }
            }
            if (b==false)
            {
                Console.WriteLine("Element not found");
            }
        }
        static void Main()
        {
            Array4 a = new Array4();
            a.Show();
        }

    }
}
