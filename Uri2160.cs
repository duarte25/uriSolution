using System;
class Uri
{
    static void Main(string[] args)
    {
        string frase = Console.ReadLine();
        
        if (frase.Length <= 80)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}