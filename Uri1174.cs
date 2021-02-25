using System;
using System.Globalization;
class Uri 
{
    static void Main(string[] args)
    {
        double[] a = new double[100];
        for (var i = 0; i < 100; i++)
        {
            a[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        for (var i = 0; i < 100; i++)
        {
           if(a[i] <= 10){
                Console.WriteLine("A["+i+"] = "+a[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}