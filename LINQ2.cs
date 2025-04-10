using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ2
    {
        static void Main()
        {
            List<string> adlist = new List<string> { "seid", "ali", "nigar", "fidan" };

            var uzunluq = adlist.Select(ad => ad.Length).ToList();

            Console.WriteLine("adlarin uzunluqlari: ");
            foreach (var ad in uzunluq)
            {
                Console.WriteLine(ad);
            }
        }
    }
}
