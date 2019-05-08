using static System.Console;
class Program
{
    static int Sign(decimal value)
    {
        switch(value)
        {
            case decimal d when value<0:
                return -1;
            case decimal d when d > 0:
                return 1;
            default:
                return 0;
        }
    }
    static void Main()
    {
        WriteLine(Sign(10));
        WriteLine(System.Math.Sign(0));
    }
}