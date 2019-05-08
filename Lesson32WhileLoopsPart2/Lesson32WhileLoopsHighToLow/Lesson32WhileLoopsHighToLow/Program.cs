using static System.Console;
class Program
{
    static void Main()
    {
        //1. print : 500,495,400,....,5,0
        int loopCounter = 500;
        while (loopCounter >= 0)
        {
            WriteLine($"value={loopCounter}");
            loopCounter -= 5;
        }
    }
}