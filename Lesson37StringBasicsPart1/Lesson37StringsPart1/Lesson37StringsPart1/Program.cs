using static System.Console;
class Program
{
    static void Main()
    {
        string s = "Hello";
        //indexes here go 0,1,2,3,4
        //length of the string is 5
        WriteLine(s.Length);
        WriteLine(s.Substring(0, 1));//H
        WriteLine(s.Substring(1, 1));//e
        WriteLine(s.Substring(2, 1));//first l
        WriteLine(s.Substring(3, 1));//second l
        WriteLine(s.Substring(4, 1));//o
        //WriteLine(s.Substring(5, 1));
        WriteLine(s.Substring(s.Length-1,1));
    }
}