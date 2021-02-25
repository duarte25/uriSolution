using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            int ano = int.Parse(Console.ReadLine());
            if (ano < 2015)
            {
                Console.WriteLine(2015-ano+" D.C.");
            }
            else if (ano > 2015)
            {
                Console.WriteLine(ano-2015+1+" A.C.");
            }
            else 
            {
                Console.WriteLine("1 A.C.");
            }
        }
    }
}