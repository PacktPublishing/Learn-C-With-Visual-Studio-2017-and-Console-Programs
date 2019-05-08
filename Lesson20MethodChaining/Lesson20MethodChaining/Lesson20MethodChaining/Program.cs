using static System.Console;
class Program
{
    static void Main()
    {

        Title = "Method Chaining!";
        BackgroundColor = System.ConsoleColor.Red;
        string s = "   Hello, World!  ";
        WriteLine(s.ToUpper().Trim());
        WriteLine(s);
        
    }
}
