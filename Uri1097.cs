using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=0;
        for (int i = 1; i <= 9; i=i+2)
        {
            for (int j1 = 0; j1 < 3; j1=j1+1)
            {
                int j=n+7-j1;
                Console.WriteLine("I="+i+" J="+j);

            }
        n=n+2;
        }
    }
}