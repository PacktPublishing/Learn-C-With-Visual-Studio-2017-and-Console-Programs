using static System.Console;
class Program
{
    //interest= amount * rate of interest
    //interest=5000*0.07
    //interest = amount *rate*time
    static decimal FindInterest(decimal amount, decimal rate, decimal t)
    {
        if (amount > 0 && rate > 0 && t > 0)
            return amount * rate*t;
        else
            return 0M;
    }

    static void Main()
    {
        decimal interest=FindInterest(10000, 0.05M,5);
        WriteLine($"interest={interest:C}");
    }
}