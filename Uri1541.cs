using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int a = int.Parse(val[0]);
       
        while (a != 0)
        {
            int b = int.Parse(val[1]);
            int c = int.Parse(val[2]);

            Console.WriteLine(Math.Truncate(Math.Sqrt(a * b * 100 / c)));

            val = Console.ReadLine().Split(' ');
            a = int.Parse(val[0]);
        }
    }
}