using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int[] x = new int[n];

        string[] leia = Console.ReadLine().Split(' ');
        int.TryParse(leia[0], out x[0]);
        int menorNumero= x[0], posicao=0;

        
        for (int i = 0; i < n; i++)
        {
            int.TryParse(leia[i], out x[i]);
            
            if (x[i] < menorNumero){
                menorNumero=x[i];
                posicao=i;
            }
        }
        Console.WriteLine("Menor valor: "+menorNumero);
        Console.WriteLine("Posicao: "+posicao);

    }
}