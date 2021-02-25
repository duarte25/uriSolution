using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        int pedido,quantidade;
        double total=0;

        pedido=Convert.ToInt32(Console.ReadLine());
        quantidade=Convert.ToInt32(Console.ReadLine());

        if(pedido == 1){
            total = quantidade*4.00;
        }else if(pedido == 2){
            total = quantidade*4.50;
        }else if(pedido == 3){
            total = quantidade*5.00;
        }else if(pedido == 4){
            total = quantidade*2.00;
        }else if(pedido == 5){
            total = quantidade*1.50;
        }

        Console.WriteLine("Total: R$ "+total.ToString("F2", CultureInfo.InvariantCulture));

    }
}