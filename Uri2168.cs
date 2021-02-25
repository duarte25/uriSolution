using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matriz = new int[n+1, n+1];

        for (int i = 0; i <= n; i++)
        {
            string[] val = Console.ReadLine().Split(' ');

            for (var j = 0; j <= n; j++)
            {
                matriz[i, j] = int.Parse(val[j]);
            }
        }


        for (int i = 0; i < n; i++)
        {
            for (var k = 0; k < n; k++)
            {
                int totalCameras = 0;
                if (matriz[i,k] == 1)
                {
                    totalCameras++;
                }

                if (matriz[i,k+1] == 1)
                {
                    totalCameras++;
                }

                if (matriz[i+1,k] == 1)
                {
                    totalCameras++;
                }

                if (matriz[i+1,k+1] == 1)
                {
                    totalCameras++;
                }

                if (totalCameras >= 2)
                {
                    Console.Write("S");
                }
                else
                {
                    Console.Write("U");
                }
            }
            Console.WriteLine();
        }
        
    }
}