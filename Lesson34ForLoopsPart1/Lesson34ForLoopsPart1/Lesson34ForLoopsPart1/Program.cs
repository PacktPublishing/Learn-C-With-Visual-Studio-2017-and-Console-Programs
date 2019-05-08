using static System.Console;
class Program
{
    static void Main()
    {
        //1. print the cubes of : 5,6,7
        //2. cubes: 5*5*5, 6*6*6, 7*7*7
        for (int i = 5; i <= 7; i++)
            WriteLine($"{i}*{i}*{i}={i * i*i}");


    }
}