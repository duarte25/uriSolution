using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val=Console.ReadLine().Split(' ');
        int m = int.Parse(val[0]);
        int n = int.Parse(val[1]);

        while (m > 0 && n > 0){
            
            int menor = m;
            int maior = n;

            if(m > n){
                menor = n;
                maior = m;
            }

            int total = 0;
            for (int i = menor; i <= maior; i++)
            {
                total = total + i;
                Console.Write(i + " ");
            }
            Console.WriteLine("Sum="+total);
            val=Console.ReadLine().Split(' ');
            m = int.Parse(val[0]);
            n = int.Parse(val[1]);
        }
    }
}