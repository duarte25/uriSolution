using System;

class Uri
{
    static void Main(string[] args)
    { 
        int x,y,min,max,soma=0;

        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());

        if (x < y) {
            min = x;
            max = y;
        } else {
            min = y;
            max = x;
        }

        for (int i = min + 1; i < max; i++) {
          if (i % 2 != 0) {
               soma = soma + i;
            }
        }

        Console.WriteLine(soma);
        
    }
}