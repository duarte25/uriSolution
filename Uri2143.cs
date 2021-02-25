using System;
class Uri
{
    static void Main(string[] args)
    {
        string val;
        while((val=Console.ReadLine()) != "0")
        {
            int t = int.Parse(val);
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int pedi = (n - 1) % 2 == 0 ? (2 * n) - 1 : (2 * n) - 2;
                Console.WriteLine(pedi);
            }

        }
    }
}