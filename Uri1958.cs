using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        double x=double.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
        if (x >= 0.0000E+00)
        {
            Console.Write("+");
        }
        Console.WriteLine(x.ToString("0.0000E+00", CultureInfo.InvariantCulture));
    }
}