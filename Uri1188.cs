using System;
namespace Uri
{
    internal static class Uri1188
    {
        static void Main(string[] args)
        {
            string letra = Console.ReadLine();
            double[,] m = new double[12, 12];
            int contador=7;
            int contadorDoY=5;
            double soma=0;

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    double.TryParse(Console.ReadLine(), out m[i, j]);
                }
            }

            for (int k = 7; k < 12; k++)
            {
                for(int y = contadorDoY; y < contador; y++){
                    soma += m[k, y];
                }
                contador++;
                contadorDoY--;
            }

            if (letra == "S") {
                Console.WriteLine(soma.ToString("F1"));
            } else {
                Console.WriteLine((soma / 30.0).ToString("F1"));
            }
        }
    }
}