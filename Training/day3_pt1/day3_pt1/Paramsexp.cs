using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_pt1
{
    internal class Paramsexp
    {
        public void Attendance(int dayno, params string[] students)
        {
            Console.Write($"Day {dayno}" + "    ");
            foreach(string student in students)
            {
                Console.Write(student + "    ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Paramsexp pe = new Paramsexp();
            pe.Attendance(1, "Eshwar", "Rakesh");
            pe.Attendance(2, "Eshwar", "Rakesh","Mukesh");

        }
    }
}
