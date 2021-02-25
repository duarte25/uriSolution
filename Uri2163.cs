using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int n = int.Parse(val[0]);
        int m = int.Parse(val[1]);
        int x = 0;
        int y = 0;

        int[,] matriz = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            val = Console.ReadLine().Split(' ');

            for (var j = 0; j < m; j++)
            {
                matriz[i, j] = int.Parse(val[j]);
            }
        }

        for (int i = 0; i <= n - 3; i++)
        {
            for (var k = 0; k <= m - 3; k++)
            {
                if (matriz[i, k] == 7 && matriz[i, k + 1] == 7 && matriz[i, k + 2] == 7 &&
                    matriz[i + 1, k] == 7 && matriz[i + 1, k + 1] == 42 && matriz[i + 1, k + 2] == 7 &&
                    matriz[i + 2, k] == 7 && matriz[i + 2, k + 1] == 7 && matriz[i + 2, k + 2] == 7)
                {
                    x = i + 2;
                    y = k + 2;
                }
            }
        }

        Console.WriteLine(x + " " + y);

    }
}