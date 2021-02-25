using System;
namespace Uri
{
    internal static class Uri1186
    {
        static void Main(string[] args)
        {
            string letra = Console.ReadLine();
            double[,] m = new double[12, 12];
            int contador=12;
            double soma=0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    double.TryParse(Console.ReadLine(), out m[i, j]);
                }
            }

            for (int k = 0; k < 12; k++)
            {
                for(int y = contador; y < 12; y++){
                    soma += m[k, y];
                }
                contador--;
            }

            if (letra == "S") {
                Console.WriteLine(soma.ToString("F1"));
            } else {
                Console.WriteLine((soma / 66.0).ToString("F1"));
            }
        }
    }
}