using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int soma=1;

        for (int i = 1; i <= n; i++)
        {
            soma=soma*i;
        }
        Console.WriteLine(soma);
    }
}