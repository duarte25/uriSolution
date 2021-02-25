using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = 1;
        int j;
        int count;

        while (n != 0)
        {
            n = int.Parse(Console.ReadLine());
            bool[] regions = new bool[n];
            for (var i = 0; i < n; i++)
            {
                n[i] = false;
            }
            for (var i = 1; i < n; i++)
            {
                count = 0;
                j = 1;
                while (count < n)
                {
                    if (j > n)
                    {
                        j = j - n;
                    }
                    Console.Write(j + " ");
                    j += i;
                    count++;
                }
                Console.WriteLine();
            }
        }

    }
}