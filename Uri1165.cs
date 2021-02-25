using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int x=int.Parse(Console.ReadLine());
            int calc=x/2;
            bool primo = true;

            for (int j = 2; j <= calc; j++)
            {
                if(x % j ==0){
                    primo = false;
                    break;
                }
            }
        
        if(primo){
            Console.WriteLine(x+" eh primo");
        }else{
            Console.WriteLine(x+" nao eh primo");
        }
            
        }
    }
}