using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        double s=0;
        double n=1.0;
        for (int i = 1; i <= 39; i+=2)
        {
            s=s+i/n;
            n=n*2.0;
        }    
        Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
    }
}