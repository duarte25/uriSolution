using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        while (n != 0)
        {
            int[,] m = new int[n, n];
            int cont=1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 && i == 0) {
                        m[i, j] = cont;
                        Console.Write(m[i, j]+" ");
                    } 
                    else if (j == 0) {
                        m[i, j] = m[i-1, 0] + m[i-1, 0];
                        Console.Write(m[i, j]+" ");
                    }
                     else if (j == n-1) {
                        m[i, j] = m[i, j-1] + m[i, j-1];
                        Console.WriteLine(m[i, j]);
                    } 
                     else {
                        m[i, j] = m[i, j-1] + m[i, j-1];
                        Console.Write(m[i, j]+" ");
                    }
                    if (n == 1) {
                        Console.WriteLine();
                    }
                }
                cont=cont+cont;
                if (i == n-1){
                    Console.WriteLine();
                }
            }
            n=int.Parse(Console.ReadLine());
        }
        
    }
}