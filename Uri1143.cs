using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int x=1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(x+" ");
            Console.Write(x*x+" ");
            Console.Write((x*x)*x+"\n");
            x++;
        }
    }
}