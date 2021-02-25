using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int numero=int.Parse(Console.ReadLine());
            Console.WriteLine((numero % 2 == 0) ? 0 : 1);
        }
    }
}