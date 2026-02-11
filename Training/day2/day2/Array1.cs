using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Array1
    {
        public void Show()
        {
            int[] a = new int[10];
            int n;
            Console.WriteLine("Enter the size of array ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter {0} elements to array", n);
            for(int i=0;i<=n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine()) ;
            }
            Console.WriteLine("The elements in array are :");
            for(int i=0;i<=n;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main()
        {
            Array1 a = new Array1();
            a.Show();
        }
    }
}
