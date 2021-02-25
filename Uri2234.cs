using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');

        double soma = Double.Parse(val[0]) / Double.Parse(val[1]);

        Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
    }
}