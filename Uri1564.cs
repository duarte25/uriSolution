using System;
class Uri
{
    static void Main(string[] args)
    {
        string numero;
        while (!string.IsNullOrEmpty(numero=Console.ReadLine())) 
        {
            int n = int.Parse(numero);
            Console.WriteLine((n == 0) ? "vai ter copa!" : "vai ter duas!");
        }
    }
}