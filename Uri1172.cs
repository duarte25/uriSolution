using System;
class Uri 
{
    static void Main(string[] args)
    {
        int[] x = new int[10];
        for (var i = 0; i < 10; i++)
        {
            x[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (var i = 0; i < 10; i++)
        {
            if(x[i] <= 0){
                x[i]=1;
            }

            Console.WriteLine("X["+i+"] = "+x[i]);
        }
    }
}