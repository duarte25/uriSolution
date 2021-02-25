using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] val = Console.ReadLine().Split(' ');
            Console.WriteLine(val[0] == "Thor"? "Y" : "N");
        }
    }
}
