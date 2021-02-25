using System;
class Uri 
{
    static void Main(string[] args)
    {
        int T=int.Parse(Console.ReadLine());
        int[] N = new int[1000];
        
        for (var i = 0; i < 1000;)
        {
            for (int j = 0; j < T && i < 1000; j++, i++)
            {
                N[i] = j;
                Console.WriteLine("N["+i+"] = "+N[i]);
             }
        }
    }
}