using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int a = int.Parse(val[0]);
        int b = int.Parse(val[1]);
        int c = int.Parse(val[2]);

        if (b < a) 
            {
                if (c >= b) 
                {
                    Console.WriteLine(":)");
                }
                else 
                {
                    if ((b - c) < (a - b)) 
                    {
                        Console.WriteLine(":)");
                    }
                    else
                    {
                        Console.WriteLine(":(");
                    }
                }
            }
            else if (b > a) 
            {
                if (c <= b)
                {
                    Console.WriteLine(":(");
                }
                else
                {
                    if ((c - b) < (b - a)) 
                    {
                        Console.WriteLine(":(");
                    }
                    else 
                    {
                        Console.WriteLine(":)");
                    }
                }
            }
            else if (a == b) 
            {
                if (c > b) 
                {
                    Console.WriteLine(":)");
                }
                else 
                {
                    Console.WriteLine(":(");
                }
            }
    }
}