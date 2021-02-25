using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        string frase="Life is not a problem to be solved, but a reality to be experienced.".ToUpper();
        Console.WriteLine(frase.Substring(0, n));
    }
}