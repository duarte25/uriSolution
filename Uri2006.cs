using System;
class Uri
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        string[] val = Console.ReadLine().Split(' ');
        int contagem = 0;

        for (var i = 0; i < 5; i++)
        {
            if(val[i] == t.ToString())
            {
                contagem++;
            }
        }

        Console.WriteLine(contagem);
    }
}