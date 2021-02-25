using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] val = Console.ReadLine().Split(' ');
        int mult2=0 , mult3=0, mult4=0, mult5 = 0;

        for (var i = 0; i < n; i++)
        {
            int numero = int.Parse(val[i]);

            mult2 = (numero % 2 == 0 ? mult2+1 : mult2);
            mult3 = (numero % 3 == 0 ? mult3+1 : mult3);
            mult4 = (numero % 4 == 0 ? mult4+1 : mult4);
            mult5 = (numero % 5 == 0 ? mult5+1 : mult5);
        }

        Console.WriteLine(mult2 + " Multiplo(s) de 2");
        Console.WriteLine(mult3 + " Multiplo(s) de 3");
        Console.WriteLine(mult4 + " Multiplo(s) de 4");
        Console.WriteLine(mult5 + " Multiplo(s) de 5");
    } 
}