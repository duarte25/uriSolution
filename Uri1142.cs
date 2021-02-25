using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int j=3;
        int y=1;

        for (int i = 0; i < n; i++)
        {
            for (int y2 = y; y2 <= j; y2++)
            {
               Console.Write(y2+" "); 
            }
            Console.Write("PUM\n");
            y=y+4;
            j=j+4;
        }
    }
}