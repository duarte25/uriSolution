using System;
class Uri 
{
    static void Main(string[] args)
    {
        int[] n = new int[10];
        int x=int.Parse(Console.ReadLine());
        for (var i = 0; i < 10; i++)
        {
            if(i==0){
                n[i] = x;
            } else{
                n[i] = n[i-1] + n[i-1];
            }
            
            Console.WriteLine("N["+i+"] = "+n[i]);
        }
    }
}