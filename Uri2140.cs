using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val = Console.ReadLine().Split(' ');
        int n = int.Parse(val[0]);
        int m = int.Parse(val[1]);

        while(m != 0 && n != 0)
        {
            int troco = m - n;
            int cedula = 0;

            while (troco >= 100 && cedula <= 2)
            {
                troco -= 100;
                cedula++;
            }
            
            while (troco >= 50 && cedula <= 2)
            {
                troco -= 50;
                cedula++;
            }
        
            while (troco >= 20 && cedula <= 2)
            {
                troco -= 20;
                cedula++;
            }
            
            while (troco >= 10 && cedula <= 2)
            {
                troco -= 10;
                cedula++;
            }
            
            while (troco >= 5 && cedula <= 2)
            {
                troco -= 5;
                cedula++;
            }

            
            while (troco >= 2 && cedula <= 2)
            {
                troco -= 2;
                cedula++;
            }

            Console.WriteLine(cedula == 2 ? "possible" : "impossible");

            val = Console.ReadLine().Split(' ');
            n = int.Parse(val[0]);
            m = int.Parse(val[1]);
        }
    }
}