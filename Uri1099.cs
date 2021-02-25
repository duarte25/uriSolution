using System;
namespace Uri1099{
    class Uri
    {
        static void Main(string[] args)
        {

            int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                string[] val = Console.ReadLine().Split(' ');
                int x=int.Parse(val[0]);
                int y=int.Parse(val[1]);

                if(x > y){
                    int xparay = x;
                    x = y;
                    y = xparay;
                }

                int soma=0;

                for(int j = x + 1; j < y; j++){
                    if (j % 2 != 0){
                        soma = soma + j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}