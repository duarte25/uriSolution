using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] val=Console.ReadLine().Split(' ');
        int x = int.Parse(val[0]);
        int y = int.Parse(val[1]);

        for (int i = 1; i <= y; i++)
        {
            Console.Write(i);
            if(i % x == 0){
                Console.WriteLine();
            }else{
                Console.Write(" ");
            }
        }
        
    }
}