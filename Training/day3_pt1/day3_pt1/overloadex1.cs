using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_pt1
{
    internal class overloadex1
    {
        public void Show(int x)
        {
            Console.WriteLine("Show w.r.t to integer: "+x); 
        }
        public void Show(double x)
        {
            Console.WriteLine("Show w.r.t to double: " + x);
        }
        public void Show(string x)
        {
            Console.WriteLine("Show w.r.t to string: " + x);
        }
        static void Main()
        {
            overloadex1 ol = new overloadex1();
            ol.Show(15);
            ol.Show(15.76);
            ol.Show("Wipro training");
        }
    }
}
