using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine(4 > 3 && 5 == 5);
        WriteLine(2 > 5 && 4 > 3);
        WriteLine(5 > 2 && 3 > 4);
        WriteLine(2 > 5 && 5 != 5);
    }
}