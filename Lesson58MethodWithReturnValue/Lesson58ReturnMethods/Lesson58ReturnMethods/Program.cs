using static System.Console;
class Program
{
    static double AddTwo(double x)
    {
        return x + 2;
    }

    static decimal DivideByFive(decimal i) => i / 5;
    static void Main()
    {
        double y=AddTwo(10);
        WriteLine(y);
        decimal p = DivideByFive(10.88M);
        WriteLine(p);
        //WriteLine(x);
        //WriteLine(i);
    }
}
