using System;
class Uri
{
    static void Main(string[] args)
    {
        int senha=2002;
        int tentativa=int.Parse(Console.ReadLine());

        while(senha != tentativa){
            Console.WriteLine("Senha Invalida");
            tentativa=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Acesso Permitido");
    }
}