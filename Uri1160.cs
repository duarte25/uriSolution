using System;
class  Uri
{
    static void Main(string[] args)
    {
        int PA, PB, crescA, crescB, anos;
        int T=int.Parse(Console.ReadLine());
        double G1, G2;
        string[] val;

        for (int i = 0; i < T; i++)
        {
            val = Console.ReadLine().Split(' ');
            PA = int.Parse(val[0]);
            PB = int.Parse(val[1]);
            G1 = double.Parse(val[2]);
            G2 = double.Parse(val[3]);
            crescA=PA;
            crescB=PB;
            anos=0;

            while(crescA <= crescB)
            {
                crescA += (int)(crescA * (G1/100));
                crescB += (int)(crescB * (G2/100));
                anos+=1;
            }
            if(anos>100){
                Console.WriteLine("Mais de 1 seculo.");
            }else{
                Console.WriteLine(anos+" anos.");
            }
        }
    }
}