using System;
using System.Linq;
class Uri
{
    static void Main(string[] args)
    {
        string numero = Console.ReadLine();
        string numeroInvertido = new string(numero.Reverse().ToArray());
        Console.WriteLine(numeroInvertido);
    }
}