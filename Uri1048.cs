using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        double salary,newSalary,readjustment,percen;
        salary=Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        if(salary <= 400.00){
            percen=15;
        }else if(salary <= 800.00){
            percen=12;
        }else if(salary <= 1200.00){
            percen=10;
        }else if(salary <= 2000.00){
            percen=7;
        }else{
            percen=4;
        }

        readjustment=salary*percen/100.00;
        newSalary=readjustment+salary;

        Console.WriteLine("Novo salario: "+newSalary.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: "+readjustment.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: "+percen.ToString("F0", CultureInfo.InvariantCulture)+" %");
    }
}