using System;
class Uri
{
    static void Main(string[] args)
    {
        string numero;
        while (!string.IsNullOrEmpty(numero=Console.ReadLine())) 
        {
            double volume = double.Parse(numero);
            double diametro = Convert.ToDouble(Console.ReadLine());
            double area = 3.14 * (diametro / 2.0) * (diametro / 2.0);
            double altura = volume / area;

            Console.WriteLine("ALTURA = " + Math.Round(altura, 2).ToString("F2"));
            Console.WriteLine("AREA = " + Math.Round(area, 2).ToString("F2"));
        }
    }
}