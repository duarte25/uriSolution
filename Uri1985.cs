using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double soma=0;

        for (int i = 0; i < n; i++)
        {    
            string[] val = Console.ReadLine().Split(' ');
            int a = int.Parse(val[0]);
            int b = int.Parse(val[1]);     
            double valor = 0;

            switch (a)
            {
                case 1001:
                    valor = 1.50;
                break;
                case 1002:
                    valor = 2.50;
                break;
                case 1003:
                    valor = 3.50;
                break;
                case 1004:
                    valor = 4.50;
                break;
                case 1005:
                    valor = 5.50;
                break;
            }

            soma = soma + (valor * b);
        }
        Console.WriteLine(soma.ToString("F2").Replace(",","."));
    }
}