using System;
class Uri
{
    static void Main(string[] args)
    {
        string val;

        while(!string.IsNullOrEmpty(val = Console.ReadLine()))
        {
            int n = int.Parse(val);

            Console.WriteLine(n - 1);
        }
    }
}