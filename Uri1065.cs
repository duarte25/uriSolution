using System;
class Uri
{
    static void Main(string[] args)
    {
        int n1,n2,n3,n4,n5,total=0;
        n1=Convert.ToInt32(Console.ReadLine());
        n2=Convert.ToInt32(Console.ReadLine());
        n3=Convert.ToInt32(Console.ReadLine());
        n4=Convert.ToInt32(Console.ReadLine());
        n5=Convert.ToInt32(Console.ReadLine());

        if(n1%2==0){
            total= total + 1;
        }if(n2%2==0){
            total= total + 1;
        }if(n3%2==0){
            total= total + 1;
        }if(n4%2==0){
            total= total + 1;
        }if(n5%2==0){
            total= total + 1;
        }

        Console.WriteLine(total+" valores pares");
    
    }
}