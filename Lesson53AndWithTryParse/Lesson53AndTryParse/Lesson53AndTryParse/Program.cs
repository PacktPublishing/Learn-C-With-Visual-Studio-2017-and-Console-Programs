using static System.Console;
using System;
class Program
{
    static void Main()
    {
        while(true)
        {
            //Clear();
            bool firstConverted=double.TryParse(ReadLine(), out double v1);
            bool secondConverted = double.TryParse(ReadLine(), out double v2);
            if (firstConverted && secondConverted)
                WriteLine($"{v1}/{v2}={v1 / v2}");
            ConsoleKey k = ReadKey(true).Key;
            if(k==ConsoleKey.Escape)
                break;
            Clear();
        }       
    }
}