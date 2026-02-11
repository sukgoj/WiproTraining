using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_p1
{
    internal class Array3
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
            int max = a[0];
            int min = a[0];
            for(int i=0;i<n;i++)
            {
                if (max < a[i])
                {
                    max = a[i]; 
                }
                if (min > a[i])
                {
                    min = a[i]; 
                }
            }
            Console.WriteLine("Max in array is " + max+" " + "Min in array is " + min); 
        }
        static void Main()
        {
            Array3 a= new Array3();
            a.Show();
        }
    }
}
