using System;
class Uri
{
    static void Main(string[] args)
    {
        string numero;
        while (!string.IsNullOrEmpty(numero=Console.ReadLine())) 
        {
            string[] val=Console.ReadLine().Split(' ');
            int maiorVelo=0;
            int n=int.Parse(numero);

            for (var i = 0; i < n; i++)
            {
                int velocidade=int.Parse(val[i]);
                if (velocidade > maiorVelo)
                {
                    maiorVelo = velocidade;
                }
            }
        
            if (maiorVelo < 10)
            {
                Console.WriteLine("1");
            } 
            else if (maiorVelo < 20) 
            {
                Console.WriteLine("2");
            }
            else 
            {
                Console.WriteLine("3");
            }
        }
    }
}