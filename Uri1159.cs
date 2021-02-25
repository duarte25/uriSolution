using System;
class Uri
{
    static void Main(string[] args)
    {
        int x=int.Parse(Console.ReadLine());;
        while (x != 0)
        {
            int soma=0;
            if (x % 2 != 0){
                x++;
            }
            for (int i = 0; i < 5; i++)
            {
                soma=soma+x;
                x+=2;
            }
            Console.WriteLine(soma);
            x=int.Parse(Console.ReadLine());
        }
    }
}