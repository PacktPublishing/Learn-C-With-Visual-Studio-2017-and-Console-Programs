using static System.Console;
class Program
{
    static void Main()
    {
        string s = ReadLine();
        //hello
        int vowelCount=0;
        foreach (char c in s)
            //a,e,i,o,u
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                vowelCount++;


        WriteLine($"vowel count:{vowelCount}");
        WriteLine($"other count:{s.Length- vowelCount}");
    } 
}