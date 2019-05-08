using static System.Console;
class Program
{
    static void Main()
    {
        //2147483647
        //79228162514264337593543950335M
        decimal bobSalary = 50000,
                johnSalary = 100000,
                adilSalary=80000;
        decimal sum = bobSalary + johnSalary+adilSalary;
        WriteLine($"Sum: {sum:C}");
        WriteLine($"Average:{sum/3:C}");

    }
}
