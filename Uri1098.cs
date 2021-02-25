using System;
class Uri
{
    static void Main(string[] args)
    {
        double n=0;
        for (double i = 0; i < 2; i=i+0.2)
        {
            for (int j1 = 0; j1 < 3; j1++)
            {
                double j=n+1+j1;
                Console.WriteLine("I="+i+" J="+j);
            }
            n=n+0.2;
        }
    }
}