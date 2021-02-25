using System;
class Uri
{
    static void Main(string[] args)
    {
        string a="";
        string b="";
        
        int n=int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) 
        {
            int num=int.Parse(Console.ReadLine());

            if(num==0){
                Console.WriteLine("NULL");
            }else{
                if(num%2==0){
                    a="EVEN";
                }else{
                    a="ODD";
                }
                if(num > 0){
                    b="POSITIVE";
                }else{
                    b="NEGATIVE";
                }
                Console.WriteLine(a+" "+b);
            }
        }
    }
}