using System;
namespace Uri1099{
    class Uri
    {
        static void Main(string[] args)
        {
            int x=int.Parse(Console.ReadLine());
            int y=int.Parse(Console.ReadLine());
            int menor=y;
            int maior=x;

            if (x < y){
                menor=x;
                maior=y;
            }

            int naoMultiplo=0;

            for(int i = menor; i <= maior; i++){
                if (i % 13 != 0){
                    naoMultiplo= naoMultiplo + i;
                }
            }

            Console.WriteLine(naoMultiplo);
            
        }
    }
}