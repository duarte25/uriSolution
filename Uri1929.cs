using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int a = int.Parse(val[0]);
        int b = int.Parse(val[1]);
        int c = int.Parse(val[2]);
        int d = int.Parse(val[3]);

        if (calcTriangulo(a, b, c) || calcTriangulo(a, b, d) || calcTriangulo(a, c, d) || calcTriangulo(b, c, d))
        {
            Console.WriteLine("S");
        } 
        else 
        {
            Console.WriteLine("N");
        }
    }

    private static bool calcTriangulo(int a, int b, int c)
    {
        return Math.Abs(b - c) < a && a < b + c &&
            Math.Abs(a - c) < b && b < a + c &&
            Math.Abs(a - b) < c && c < a + b;
    }
}