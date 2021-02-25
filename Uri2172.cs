using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int n = int.Parse(val[0]);
        int m = int.Parse(val[1]);

        while(!(m == 0 && n == 0))
        {
            Console.WriteLine(n*m);

            val = Console.ReadLine().Split(' ');
            n = int.Parse(val[0]);
            m = int.Parse(val[1]);
        }        
    }
}