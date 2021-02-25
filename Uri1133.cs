using System;
class Uri{
    static void Main(string[] args)
    {
        int x=int.Parse(Console.ReadLine());
        int y=int.Parse(Console.ReadLine());

        int maior=x;
        int menor=y;
        if (x < y){
            menor=x;
            maior=y;
        }

        for(int i = menor+1; i < maior; i++){
            if (i % 5 == 2 || i % 5 == 3){
                Console.WriteLine(i);
            }
        }
    }
}