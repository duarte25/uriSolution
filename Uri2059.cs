using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int p = int.Parse(val[0]);
        int j1 = int.Parse(val[1]);
        int j2 = int.Parse(val[2]);
        int r = int.Parse(val[3]);
        int a = int.Parse(val[4]);

        int vencedor = 0;
        
        if ((j1 + j2) % 2 == 0)
        {
            vencedor = p == 1 ? 1: 2;
        }
        else 
        {
            vencedor = p == 0 ? 1: 2;
        }

        bool roubou = r == 1 ? true: false;
        
        if (a == 1)
        {
            Console.WriteLine("Jogador "+(roubou == true ? 2 : 1)+" ganha!");
        }
        else
        {
            Console.WriteLine("Jogador "+(roubou == true ? 1 : vencedor)+" ganha!");
        }
    } 
}