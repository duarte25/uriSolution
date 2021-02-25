using System;
class Uri
{
    static void Main(string[] args)
    {
        int x,fim;
        
        x=Convert.ToInt32(Console.ReadLine());

        fim = x + 12;

        for (int i = x; i < fim; i++)
        {
            if(i%2 > 0 && i>0){
                Console.WriteLine(i);
            }
        }


    }
}