using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_p1
{
    internal class Array5
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
            Console.WriteLine("enter the element to delete");
            x = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n;i++)
            {
                if(a[i] == x)
                {
                    for(int j=i;j<n;j++)
                    {
                        a[j] = a[j + 1];
                    }
                    n--;
                }
            }
            Console.WriteLine("list after deleting");
            for(int i = 0; i < n;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main()
        {
            Array5 a=new Array5();
            a.Show();
        }
    }
}
