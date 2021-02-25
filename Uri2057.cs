using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int s = int.Parse(val[0]);
        int t = int.Parse(val[1]);
        int f = int.Parse(val[2]);

        int horaDestino = s + t + f;

        if (horaDestino > 24)
        {
            horaDestino = horaDestino - 24;
        } 
        else if (horaDestino < 0)
        {
            horaDestino = 24 + horaDestino;
        }
        
        Console.WriteLine(horaDestino);

    }
}