using System;
class Uri
{
    static void Main(string[] args)
    {
        int a,n,i,soma; 
        string[] val=Console.ReadLine().Split(' ');

        a=int.Parse(val[0]);
        i=1;
        n=int.Parse(val[i]);
        while (n <= 0){
            i = i + 1;
            n=int.Parse(val[i]);
        }
        
        soma=0;
        for (int j = 0; j < n; j++)
        {
            soma = soma + a + j;
        }
        Console.WriteLine(soma);

    }
}