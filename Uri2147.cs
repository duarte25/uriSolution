using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        
        int n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            string b = Console.ReadLine();

            Console.WriteLine((b.Length / 100.0).ToString("F2", CultureInfo.InvariantCulture));
        }
        
    }
}