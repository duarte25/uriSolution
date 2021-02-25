using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] reguaTomada = Console.ReadLine().Split(' ');
        int T1 = int.Parse(reguaTomada[0]);
        int T2 = int.Parse(reguaTomada[1]);
        int T3 = int.Parse(reguaTomada[2]);
        int T4 = int.Parse(reguaTomada[3]);

        Console.WriteLine((T1+T2+T3+T4)-3);
    }
}