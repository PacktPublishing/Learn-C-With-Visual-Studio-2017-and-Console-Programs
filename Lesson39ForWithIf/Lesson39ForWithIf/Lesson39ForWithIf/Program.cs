using static System.Console;
class Program
{
    static void Main()
    {
        string s = "$7fd(*)3533%$m.?";
        foreach (char c in s)
        {
            if (char.IsPunctuation(c))
                WriteLine(c);
        }            
    }
}