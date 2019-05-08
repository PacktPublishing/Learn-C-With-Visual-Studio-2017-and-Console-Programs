using static System.Console;
class Program
{
    static void Main()
    {
        BackgroundColor = System.ConsoleColor.Blue;
        //collect input until somebody types exit
        string textFinal=null;
        string temp;
        while ((temp=ReadLine()) != "exit")
            textFinal += temp+" ";

        WriteLine(textFinal);

    }
}