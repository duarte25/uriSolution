using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());

        double resul = (Math.Pow((1 + Math.Sqrt(5)) / 2, n) - Math.Pow((1 - Math.Sqrt(5)) / 2, n)) / Math.Sqrt(5);

        Console.WriteLine(resul.ToString("F1", CultureInfo.InvariantCulture));
    }
}