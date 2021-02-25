using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            if (i == n-1) {
                Console.WriteLine("Ho!");
            } else {
                Console.Write("Ho ");
            }
        }
    }
}