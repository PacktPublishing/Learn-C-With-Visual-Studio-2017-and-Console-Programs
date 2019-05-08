using static System.Console;
class Program
{
    static void Main()
    {
        ////1. print the squares of : 1,2,3
        ////2. 1+2, 2+2, 3+2:3, 4, 5
        ////3. still create: 1*1, 2*2, 3*3
        //for (int i =3; i<=5; i++)
        //    WriteLine($"{i-2}*{i-2}={(i-2)*(i-2)}");
        //1. print the squares of : 1,2,3
        //2. 1-3, 2-3, 3-3:-2, -1, 0
        //3. still create: 1*1, 2*2, 3*3
        for (int i = -2; i <= 0; i++)
            WriteLine($"{i +3}*{i +3}={(i +3) * (i +3)}");

    }
}