using static System.Console;
class Program
{
    static void Main()
    {
        string s = "Hello";
        for (int i = s.Length-1; i>=0; i--)
            WriteLine(s.Substring(i, 1));
    }
}