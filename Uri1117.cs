using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        double n1=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (n1 < 0 || n1 > 10)
        {
            Console.WriteLine("nota invalida");
            n1=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double n2=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (n2 < 0 || n2 > 10)
        {
            Console.WriteLine("nota invalida");
            n2=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double soma=(n1+n2)/2.00;

        Console.WriteLine("media = "+soma.ToString("F2", CultureInfo.InvariantCulture));
    }
}