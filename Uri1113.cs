using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val=Console.ReadLine().Split(' ');
        int x = int.Parse(val[0]);
        int y = int.Parse(val[1]);

        while(x != y){

            if(x > y){
                Console.WriteLine("Decrescente");
            }else{
                Console.WriteLine("Crescente");
            }

            val=Console.ReadLine().Split(' ');
            x = int.Parse(val[0]);
            y = int.Parse(val[1]);
        }
    }
}