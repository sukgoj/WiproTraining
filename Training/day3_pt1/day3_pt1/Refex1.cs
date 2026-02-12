using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_pt1
{
    internal class Refex1
    {
        public void Show(ref int x)
        {
            x++;
        }
        static void Main()
        {
            Refex1 rf = new Refex1();
            int x = 12;
            rf.Show(ref x);
            Console.WriteLine(x);

        }
    }
}
