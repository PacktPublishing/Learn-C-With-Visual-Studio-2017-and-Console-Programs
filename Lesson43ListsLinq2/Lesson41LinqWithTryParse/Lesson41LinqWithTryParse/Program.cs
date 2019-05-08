using static System.Console;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<double> l = new List<double>();
        while (double.TryParse(ReadLine(), out double v))
                  l.Add(v);

        WriteLine($"Sum={l.Sum()}" +
            $"\nAverage:{l.Average()}");

    }
}