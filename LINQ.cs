using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> regemler = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var tekregemler = regemler.Where(reg => reg % 2 != 0).ToList();

        Console.WriteLine("Tek regemler: ");
        foreach( var reg in tekregemler)
        {
            Console.WriteLine(reg);
        }
    }
}
