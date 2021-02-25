using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int abas = int.Parse(val[0]);
        int m = int.Parse(val[1]);

        for (var i = 0; i < m; i++)
        {
            string action = Console.ReadLine();
            abas = (action == "fechou" ? abas + 1: abas - 1);
        }
        Console.WriteLine(abas);
    }
}