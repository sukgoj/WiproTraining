using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_pt1
{
    internal class NamedParams
    {
        public void Show(string firstname, string lastname , string city , string state)
        {
            Console.WriteLine($"firstname: {firstname} lastname: {lastname} city: {city} state: {state}");
        }
        static void Main()
        {
            NamedParams np = new NamedParams();
            np.Show(city: "jammikunta", firstname: "Eshwar", lastname: "Bachu", state: "Telangana");
            np.Show("jammikunta", "Eshwar", "Bachu", "Telangana");

        }
    }
}
