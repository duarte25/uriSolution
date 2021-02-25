using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        string[] val2 = Console.ReadLine().Split(' ');
        int p = int.Parse(val[0]);
        int n = int.Parse(val[1]);
        int[] pulosInt = new int[n];
        bool gameOver=false;

        for (var i = 0; i < n; i++)
        {
            pulosInt[i] = int.Parse(val2[i]);

            if (i==0)
            {

            }
            else if (pulosInt[i] - pulosInt[i-1] > p || pulosInt[i-1] - pulosInt[i] > p)
            {
                gameOver=true;
            }
        }
        Console.WriteLine(gameOver ? "GAME OVER" : "YOU WIN");    
    }
}