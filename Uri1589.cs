using System;
class Uri
{
    static void Main(string[] args)
    {
        int T=int.Parse(Console.ReadLine());

        for (var i = 0; i < T; i++)
        {       
            string[] val = Console.ReadLine().Split(' ');
            int R1 = Convert.ToInt32(val[0]);
            int R2 = Convert.ToInt32(val[1]);
            Console.WriteLine(R1 + R2);
        }
    }
}