using static System.Console;
class Program
{
    static void Main()
    {
        string s1 = "Hello";
        string s2 = ",World";
        string s3 = "\nGood morning!";
        string s4=System.String.Concat(s1, s2,s3);
        WriteLine(s4);
    }
}
