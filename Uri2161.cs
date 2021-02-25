using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double t = 0;
        for (int i = 0; i < n; i++)
        {
            t += 6.0;
            t = 1.0 / t;
        }
        t += 3.0;
        Console.WriteLine(t.ToString("F10", CultureInfo.InvariantCulture));
    }
}