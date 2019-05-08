using static System.Console;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<decimal> l;
        l = new List<decimal> {5,53.45M, 898.98M };
        WriteLine($"Sum:{l.Sum()}");
        //average, min, max
        WriteLine($"Average:{l.Average()}");
        WriteLine($"Min:{l.Min()}");
        WriteLine($"Max:{l.Max()}");
    }
}