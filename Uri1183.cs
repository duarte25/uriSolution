using System;

namespace uri1183
{
    internal static class Program
    {
        private static void Main()
        {
            string t = Console.ReadLine();
            double[,] m = new double[12, 12];
            double soma = 0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    double.TryParse(Console.ReadLine(), out m[i, j]);
                }
            }

            for (int k = 0; k < 12; k++)
            {
                for(int y = k + 1; y < 12; y++){
                    soma += m[k, y];
                }
            }

            if (t == "S")
            {
                Console.WriteLine(soma.ToString("F1"));
            }
            else
            {
                Console.WriteLine((soma / 66.0).ToString("F1"));
            }
        }
    }
}