using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());

        for (var i = 1; i <=10 ; i++)
        {
            int soma= i * n;

            Console.WriteLine(i+" x "+n+" = "+soma);
        }
    }
}