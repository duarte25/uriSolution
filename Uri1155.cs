using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        double s=0;
        for (int i = 1; i <= 100; i++)
        {
            s=s+1.0/i;
        }
        Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
    }
}