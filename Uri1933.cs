using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int a = int.Parse(val[0]);
        int b = int.Parse(val[1]);

        Console.WriteLine(a > b ? a : b);
    }
}