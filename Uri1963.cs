using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        double a = double.Parse(val[0]);
        double b = double.Parse(val[1]);
        Console.WriteLine("Eerro "+b);

        Console.WriteLine((((b - a) / a) * 100.0).ToString("F2")+"%");
    }
}