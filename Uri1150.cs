using System;
class Uri
{
    static void Main(string[] args)
    {
        int x=int.Parse(Console.ReadLine());
        int z=int.Parse(Console.ReadLine());

        while (z <= x)
        {
            z=int.Parse(Console.ReadLine());
        }
        int cont=1;
        int soma=x;
        while (soma <= z)
        {
            x = x + 1;
            soma=soma + x;
            cont=cont + 1;
        }
        Console.WriteLine(cont);
    }
}