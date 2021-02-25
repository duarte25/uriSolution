using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        double n1,n2,n3,n4,n5,n6,total=0;
        int pos=0;

        n1=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        n2=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        n3=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        n4=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        n5=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        n6=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(n1 > 0.0){
            pos = pos + 1;
            total=n1;
        }if(n2 > 0.0){
            pos = pos + 1;
            total= total + n2;
        }if(n3 > 0.0){
            pos = pos + 1;
            total= total + n3;
        }if(n4 > 0.0){
            pos = pos + 1;
            total= total + n4;
        }if(n5 > 0.0){
            pos = pos + 1;
            total= total + n5;
        }if(n6 > 0.0){
            pos = pos + 1;
            total= total + n6;
        }

        Console.WriteLine(pos+" valores positivos");
        Console.WriteLine((total/pos).ToString("F1", CultureInfo.InvariantCulture));

    }
}