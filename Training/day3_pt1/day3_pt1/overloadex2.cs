using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_pt1
{
    internal class overloadex2
    {
        public int Sum()
        {
            return 12;
        }
        public int Sum(int x)
        {
            return x + 10;
        }
        public int Sum(int x , int y)
        {
            return x + y; 
        }
        static void Main()
        {
            overloadex2 ol = new overloadex2();
            Console.WriteLine("Sum w.r.t to zero args: "+ol.Sum());
            Console.WriteLine("Sum w.r.t to one args: " + ol.Sum(10));
            Console.WriteLine("Sum w.r.t to two args: " + ol.Sum(10,12));

        }
    }
}
