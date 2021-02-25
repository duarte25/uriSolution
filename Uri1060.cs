using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        double n1,n2,n3,n4,n5,n6;
        int pos=0;

        n1=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        n2=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        n3=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        n4=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        n5=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        n6=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(n1 > 0.0){
            pos = pos + 1;
        }if(n2 > 0.0){
            pos = pos + 1;
        }if(n3 > 0.0){
            pos = pos + 1;
        }if(n4 > 0.0){
            pos = pos + 1;
        }if(n5 > 0.0){
            pos = pos + 1;
        }if(n6 > 0.0){
            pos = pos + 1;
        }

        Console.WriteLine(pos+" valores positivos");

    }
}