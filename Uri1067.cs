using System;

class Uri
{
    static void Main(string[] args)
    { 
        int x=Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= x; i = i + 2) 
        {
            if(i%2 > 0 && i>0){
                Console.WriteLine(i);
            }
        }

    }
}