using static System.Console;
class Program
{
    static void Main()
    {
        string name="Bobo";
        decimal price = 4.50M;
        double height=15.1;
        bool hasUmbrella = true;
        string desc =
            $"Name: {name} \nPrice:{price:C}" +
            $"\nHeight:{height} cm " +
            $"\nHas Umbrella:{hasUmbrella}";
        WriteLine(desc);
    }
}
