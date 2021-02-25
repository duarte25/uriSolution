using System;
class Uri
{
    static void Main(string[] args)
    {
        int[] par = new int[5];
        int[] impar = new int[5];
        int contPar=0;
        int contImpar=0;

        for (int i = 0; i < 15; i++)
        {
            int numero=int.Parse(Console.ReadLine());

            if(numero % 2 == 0){
                par[contPar]=numero;
                contPar++;
            } else {
                impar[contImpar]=numero;
                contImpar++;
            }

            if (contPar == 5){
                for (int contagem = 0; contagem < 5; contagem++)
                {
                    Console.WriteLine("par["+contagem+"] = "+par[contagem]);
                }
                contPar=0;
            } else if (contImpar == 5){
                for (int contagem = 0; contagem < 5; contagem++)
                {
                    Console.WriteLine("impar["+contagem+"] = "+impar[contagem]);
                }
                contImpar=0;
            }
        }

         if (impar[0] > 0){
            for (int i = 0; i < contImpar; i++)
            {
                Console.WriteLine("impar["+i+"] = "+impar[i]);
            }
        }

        if (par[0] > 0){
            for (int i = 0; i < contPar; i++)
            {
                Console.WriteLine("par["+i+"] = "+par[i]);
            }
        }
        
    }
}