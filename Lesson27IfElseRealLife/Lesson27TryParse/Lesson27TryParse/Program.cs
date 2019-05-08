using static System.Console;
class Program
{
    static void Main()
    {
        WriteLine("Enter First Value");
        //double.TryParse(ReadLine(), out double value1)
        if (true)
        {
            //double.TryParse(ReadLine(), out double value2)
            WriteLine("Enter Second Value:");
            if (true)
                WriteLine($"{value1}*{value2} ={value1 * value2}");
            else
                WriteLine("Second input can't be converted.");
        }           
        else
            WriteLine("First input can't be converted");
    }
}