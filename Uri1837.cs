using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int a = int.Parse(val[0]);
        int b = int.Parse(val[1]);

        double divisor=a/b;
        int resto=a%b;

        Console.WriteLine(Math.Round(divisor)+" "+resto);
       
    }
}