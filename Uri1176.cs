using System;
class Uri 
{
    static void Main(string[] args)
    {
        Int64[] a = new Int64[61];
        for (var i = 0; i <= 60; i++)
        {
            if (i==0){
                a[i]=0;
            } else if (i==1){
                a[i]=1;
            } else {
                a[i] = a[i-1]+a[i-2];
            }
        }
        int T=int.Parse(Console.ReadLine());
        for (var i = 0; i < T; i++)
        {
            int fib=int.Parse(Console.ReadLine());
            Console.WriteLine("Fib("+fib+") = "+a[fib]);
        }
    }
}