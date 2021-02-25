using System;
class Uri 
{
    static void Main(string[] args)
    {
        int[] n = new int[20];
        for (var i = 0; i < 20; i++)
        {
            n[i] = int.Parse(Console.ReadLine());
        }

        for (var i = 0; i < 20; i++)
        {
           
            Console.WriteLine("N["+i+"] = "+n[19-i]);
            
        }
    }
}