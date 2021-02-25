using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] nomeEscolha = Console.ReadLine().Split(' ');
            string[] valor = Console.ReadLine().Split(' ');
            int jogadorUm=int.Parse(valor[0]);
            int jogadorDois=int.Parse(valor[1]);

            int soma = jogadorUm+jogadorDois;

            if (soma % 2 == 0)
            {
                Console.WriteLine(("PAR" == nomeEscolha[1]) ? nomeEscolha[0] : nomeEscolha[2]);
            }
            else 
            {
                Console.WriteLine(("IMPAR" == nomeEscolha[1]) ? nomeEscolha[0] : nomeEscolha[2]);
            }
        }
    }
}