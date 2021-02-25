using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val=Console.ReadLine().Split(' ');
        int x = int.Parse(val[0]);
        int y = int.Parse(val[1]);

        while(x != 0 && y != 0){
            if(x > 0 && y > 0){
                Console.WriteLine("primeiro");
            }else if(x < 0 && y > 0){
                Console.WriteLine("segundo");
            }else if(x < 0 && y < 0){
                Console.WriteLine("terceiro");
            }else{
                Console.WriteLine("quarto");
            }

            val=Console.ReadLine().Split(' ');
            x = int.Parse(val[0]);
            y = int.Parse(val[1]);  
        }
    }
}