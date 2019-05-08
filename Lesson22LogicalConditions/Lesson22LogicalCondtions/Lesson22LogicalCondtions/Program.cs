using static System.Console;
class Program
{
    static void Main()
    {
        int x = 11, y = 10;
        WriteLine($"{x}={y}?: {x==y}");
        WriteLine($"{x}<={y}? { x<=y}");
        WriteLine($"{x}>{y}? { x > y}");
        WriteLine($"{x}!={y}? {x != y}");
    }
}
