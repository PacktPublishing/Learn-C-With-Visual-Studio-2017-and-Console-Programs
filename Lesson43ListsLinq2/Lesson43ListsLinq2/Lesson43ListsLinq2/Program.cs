using static System.Console;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<decimal> l = new List<decimal> {1, 2};
        l.ForEach(x => WriteLine($"{x}^2={x*x}"));
        //redo the list with the decimal data type
        //and show the value of each entry in the list

        //show the square of each value in the list
    }
}