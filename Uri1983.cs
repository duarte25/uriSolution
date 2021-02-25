using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
            int[] matriculas = new int[n];
            double[] notas = new double[n];
            bool reached = false;
            int maiorIndice = 0;
            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int.TryParse(entrada[0], out matriculas[i]);
                double.TryParse(entrada[1], out notas[i]);
            }
            for (int j = 0; j < n; j++)
            {
                if (notas[j] >= 8.0)
                {
                    reached = true;
                }

                if (notas[j] > notas[maiorIndice])
                {
                    maiorIndice = j;
                }
            }
            if (!reached)
            {
                Console.WriteLine("Minimum note not reached");
            }
            else
            {
                Console.WriteLine(matriculas[maiorIndice]);
            }
    }    
}