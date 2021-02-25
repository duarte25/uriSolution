using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        int alcool=0;
        int gaso=0;
        int diesel=0;

        while (n != 4)
        {
            switch (n)
            {
                case 1:
                    alcool=alcool+1;
                    break;
                case 2:
                    gaso=gaso+1;
                    break;
                case 3:
                    diesel=diesel+1;
                    break;
            }
            n=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: "+alcool);
        Console.WriteLine("Gasolina: "+gaso);
        Console.WriteLine("Diesel: "+diesel);
    }
}