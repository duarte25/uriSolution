using System;
class Uri
{
    static void Main(string[] args)
    {
        string val;
        while (!string.IsNullOrEmpty(val = Console.ReadLine()))
        {
            var hora = DateTime.Parse(val);
            var limite = DateTime.Parse("8:00");
            if (hora.Hour < 7)
            {
                Console.WriteLine("Atraso maximo: 0");
            }
            else 
            {
                TimeSpan atraso = hora.AddHours(1) - limite;
                Console.WriteLine("Atraso maximo: "+ atraso.TotalMinutes);
            }
        }
    }
}