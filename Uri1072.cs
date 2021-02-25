using System;
class Uri
{
    static void Main(string[] args)
    {

        int n=Convert.ToInt32(Console.ReadLine());

        int contIn=0;
        int contOut=0;

        for (var i = 0; i < n; i++)
        {
            int x=Convert.ToInt32(Console.ReadLine());
            if(x >= 10 && x <= 20){
                contIn++;
            }else{
                contOut++;
            }
        }

        Console.WriteLine(contIn+" in");
        Console.WriteLine(contOut+" out");

    }
}