using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        uint.TryParse(val[0], out uint n);
        uint.TryParse(val[1], out uint l);

        Console.WriteLine(n*l);
    }
}