using System;
class Uri
{
    static void Main(string[] args)
    {
        string numero;
        int caso=0;
        while (!string.IsNullOrEmpty(numero=Console.ReadLine())) 
        {
            caso++;
            int n=int.Parse(numero);
            int cont = MyMethod(n);
            
            if (n == 0)
            {
                Console.WriteLine("Caso "+caso+": 1 numero");
            }
            else 
            {
                Console.WriteLine("Caso "+caso+": "+cont+" numeros");
            }
            
            for (int i = 0; i <= n; i++)
            {
                if (i==0)
                {
                    Console.Write("0 ");
                }

                for (var j = 0; j < i; j++)
                {
                    Console.Write(i+" ");   
                }
            }
            Console.WriteLine();
        }
    }
    
    static int MyMethod(int n)
    {
        int contagem=1;
        for (int i = 0; i <= n; i++)
        {
            for (var j = 0; j < i; j++)
            {
                contagem++;
            }
        }
        return contagem;
    }
}