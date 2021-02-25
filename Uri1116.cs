using System;
using System.Globalization;
namespace uri1116
{
    class Uri
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] val=Console.ReadLine().Split(' ');
                int x = int.Parse(val[0]);
                int y = int.Parse(val[1]);

                if(y == 0){
                    Console.WriteLine("divisao impossivel");
                }else{
                double div=(double)x/y;
                Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}