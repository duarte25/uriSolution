using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            string[] val = Console.ReadLine().Split(' ');
            int h = int.Parse(val[0]);
            int m = int.Parse(val[1]);
            string o = val[2];

            if (h < 10 && m < 10)
            {
                Console.WriteLine("0"+h+":"+"0"+m+" - A porta "+(o == "1" ? "abriu!" : "fechou!"));
            }
            else if (h < 10 && m >= 10)
            {
                Console.WriteLine("0"+h+":"+m+" - A porta "+(o == "1" ? "abriu!" : "fechou!"));
            }
            else if (h >= 10 && m < 10)
            {
                Console.WriteLine(h+":"+"0"+m+" - A porta "+(o == "1" ? "abriu!" : "fechou!"));
            }
            else
            {
                Console.WriteLine(h+":"+m+" - A porta "+(o == "1" ? "abriu!" : "fechou!"));
            }          
        }
    }
}