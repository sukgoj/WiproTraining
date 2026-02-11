using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_p1
{
    internal class Array2
    {
        public void Show()
        {
            int[] a = new int[10];
            int n;
            Console.WriteLine("enter size of array");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter {0} elements to array",n);
            for (int i = 0; i < n; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            int sum =0;
            for(int i =0;i<n;i++)
            {
                sum += a[i]; 
            }
            Console.WriteLine("Sum is " + sum);

        }
        static void Main()
        {
            Array2 a = new Array2();
            a.Show();

        }
    }
}
