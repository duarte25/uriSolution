using System;
namespace Uri
{
    internal static class Uri1190
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

            for (int k = 1; k < 11; k++)
            {   
                if (k < 6){
                    contador--;
                } if (k > 6 && k < 11) {
                    contador++;
                }

                for(int y = contador; y < 12; y++){
                    soma += m[k, y];
                }
            }

            if (letra == "S") {
                Console.WriteLine(soma.ToString("F1"));
            } else {
                Console.WriteLine((soma / 30.0).ToString("F1"));
            }
        }
    }
}