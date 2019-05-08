using static System.Console;
class Program
{
    static void Main()
    {
        //4<5, 4==5, 4>5
        double x = 12, y = 12;
        if (x < y)
            WriteLine($"{x}<{y}");
        else if (x == y)
            WriteLine($"{x}={y}");
        else
            WriteLine($"{x}>{y}");
    }
}