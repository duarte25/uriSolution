using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double raiz = 0;

        for (var i = 0; i < n; i++)
        {
            raiz += 2;
            raiz = 1 / raiz;
        }
        raiz++;
        Console.WriteLine(raiz.ToString("F10"));
    }
}