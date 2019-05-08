using static System.Console;
class Program
{
    static void Main()
    {
        //1. print : 5,10,15,20,25,30
        int index = 5;
        while(index<=30)
        {
            WriteLine($"value={index}");
            index+=5;
        }
    }
}