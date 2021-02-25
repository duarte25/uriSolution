using System;
class Uri
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        double[] matriz = new double[2];

        for (var i = 0; i < t; i++)
        {
            int bonus = int.Parse(Console.ReadLine());

            for (var j = 0; j < 2; j++)
            {
                string[] val = Console.ReadLine().Split(' ');
                int ataque = int.Parse(val[0]);
                int defesa = int.Parse(val[1]);
                int level = int.Parse(val[2]);
                
                matriz[j] = (level % 2 == 0) ? ((ataque + defesa) / 2.0 ) + bonus : (ataque + defesa) / 2.0; 
            }

            Console.WriteLine(matriz[0] == matriz[1] ? "Empate" : matriz[0] > matriz[1] ? "Dabriel" : "Guarte");
            
        }
    }
}