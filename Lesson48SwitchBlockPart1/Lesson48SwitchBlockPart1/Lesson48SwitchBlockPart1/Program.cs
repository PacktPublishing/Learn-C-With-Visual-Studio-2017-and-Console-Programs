using static System.Console;
class Program
{
    static void Main()
    {
        string op = "/";
        double x = -4.53, y = 0;
        switch(op)
        {
            case "/":
                if (y != 0)
                    WriteLine($"{x}/{y}={x / y}");                     
                else
                     WriteLine("Cannot divide by zero");       
                break;
            //define +, -, *
            case "*":
                WriteLine($"{x}*{y}={x * y}");
                break;
            case "+":
                WriteLine($"{x}+{y}={x + y}");
                break;
            case "-":
                WriteLine($"{x}-{y}={x - y}");
                break;
        }
    }
}