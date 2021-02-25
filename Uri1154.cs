using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        int idade=int.Parse(Console.ReadLine());
        int soma=0;
        int i=0;
    
        while (idade>=0)
        {
            soma = soma + idade;
            i=i+1;
            idade=int.Parse(Console.ReadLine());
        }
        double calculo=(double)soma/i;
        Console.WriteLine(calculo.ToString("F2", CultureInfo.InvariantCulture));
    }
}