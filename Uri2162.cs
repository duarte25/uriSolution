using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] val = Console.ReadLine().Split(' ');
        bool certo = false;

        for (var i = 1; i < n; i++)
        {
            if (int.Parse(val[i-1]) < int.Parse(val[i]) && int.Parse(val[i+1]) > int.Parse(val[i]))
            {
                certo = true;
            }
        }

        Console.WriteLine(certo ? "1" : "0");
    }
}