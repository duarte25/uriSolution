using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double p = n / Math.Log(n);
        Console.WriteLine(p.ToString("F1", CultureInfo.InvariantCulture)+
                        " "+(1.25506 * p).ToString("F1", CultureInfo.InvariantCulture));

    }
}