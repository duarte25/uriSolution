using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] val = Console.ReadLine().Split(' ');
        int resul = 0;

        for (var i = 1; i < n; i++)
        {
            if (int.Parse(val[i]) < int.Parse(val[i-1]))
            {
                resul = i + 1;
                i = n;
            }
        }
        Console.WriteLine(resul);
    }
}