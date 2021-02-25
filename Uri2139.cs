using System;
class Uri
{
    static void Main(string[] args)
    {
        string data;
        while(!string.IsNullOrEmpty(data=Console.ReadLine()))
        {
            string[] val = data.Split(' ');
            int mes = int.Parse(val[0]);
            int dia = int.Parse(val[1]);

            if (mes == 12 && dia == 25)
            {
                Console.WriteLine("E natal!");
            }
            else if (mes == 12 && dia == 24)
            {
                Console.WriteLine("E vespera de natal!");
            }
            else if (mes == 12 && dia > 25)
            {
                Console.WriteLine("Ja passou!");
            }
            else
            {
                var d = new DateTime(2016, mes, dia);
                var natal = new DateTime(2016, 12, 25);
                TimeSpan t = natal.Subtract(d);
                Console.WriteLine("Faltam "+t.TotalDays+" dias para o natal!");
            }
        }
    }
}