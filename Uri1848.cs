using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=0;
        int contagem=0;
        while (n < 3)
        {
            string valor=Console.ReadLine();
            if (valor == "caw caw")
            {
                n++;
                Console.WriteLine(contagem);
                contagem=0;
            }
            else 
            {
                if(valor[0] == '*')
                {
                    contagem += 4;
                }
                if (valor[1] == '*')
                {
                    contagem += 2;
                }
                if (valor[2] == '*')
                {
                    contagem ++;
                }
            }
        }
    }
}

