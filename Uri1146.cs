using System;
class uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());

        while (n != 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if(i % n == 0){
                    Console.WriteLine();
                }else{
                    Console.Write(" ");
                }
            }    
            n=int.Parse(Console.ReadLine());
        }
    }
}