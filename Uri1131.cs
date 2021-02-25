using System;
class Uri
{
    static void Main(string[] args)
    {
        int winInter=0;
        int winGremio=0;
        int empates=0;
        int grenais=0;
        int novoCalc=1;

        while (novoCalc == 1)
        {   
            string[] val=Console.ReadLine().Split(' ');
            int inter = int.Parse(val[0]);
            int gremio = int.Parse(val[1]);

            grenais=grenais+1;
            if(inter == gremio){
                empates = empates + 1;
            } else if(inter > gremio){
                winInter = winInter + 1;
            } else if(inter < gremio){
                winGremio = winGremio + 1;
            }

            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            novoCalc=int.Parse(Console.ReadLine());
        }
        Console.WriteLine(grenais+" grenais");
        Console.WriteLine("Inter:"+winInter);
        Console.WriteLine("Gremio:"+winGremio);
        Console.WriteLine("Empates:"+empates);

        if(winInter>winGremio){
            Console.WriteLine("Inter venceu mais");
        }else{
            Console.WriteLine("Gremio venceu mais");
        }

    }
}