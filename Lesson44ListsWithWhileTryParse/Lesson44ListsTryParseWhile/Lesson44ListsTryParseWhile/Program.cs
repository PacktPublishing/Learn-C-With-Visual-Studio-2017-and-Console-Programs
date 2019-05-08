using static System.Console;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<double> l = new List<double>();
        //"10","ten"

        while (double.TryParse(ReadLine(), out double result))
            l.Add(result);

        //add ability to show sum and average of list
        WriteLine($"Sum:{l.Sum()}" +
            $"\nAverage:{l.Average()}");
    }
}