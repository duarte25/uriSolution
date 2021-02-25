using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] val = Console.ReadLine().Split(' ');
            int x = int.Parse(val[0]);
            int y = int.Parse(val[1]);
            int soma=0;

            if(x % 2 == 0){
                x++;
            }
            
            for (int j = 1; j <= y; j++)
            {
                soma=soma+x;
                x+=2;
            }
            Console.WriteLine(soma);
        }
    }
}