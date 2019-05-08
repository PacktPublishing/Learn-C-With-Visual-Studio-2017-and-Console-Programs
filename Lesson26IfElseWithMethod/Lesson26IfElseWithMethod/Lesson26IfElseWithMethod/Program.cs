using static System.Console;
class Program
{
    static void Main()
    {
        string text = "hello";
        string texToFind = "sd";
        if (text.Contains(texToFind))
            WriteLine($"{texToFind} found in {text}");
        else
            WriteLine($"{texToFind} not found in {text}");
    }
}