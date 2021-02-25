using System;
class Uri
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            switch (a)
            {
                case "ataque":
                    switch (b)
                    {
                        case "ataque":
                            Console.WriteLine("Aniquilacao mutua"); break;
                        case "pedra":
                        case "papel":
                            Console.WriteLine("Jogador 1 venceu"); break;
                    }

                    break;

                case "pedra":
                    switch (b)
                    {
                        case "ataque":
                            Console.WriteLine("Jogador 2 venceu"); break;
                        case "pedra":
                            Console.WriteLine("Sem ganhador"); break;
                        case "papel":
                            Console.WriteLine("Jogador 1 venceu"); break;
                    }
                    break;

                case "papel":
                    switch (b)
                    {
                        case "ataque":
                            case "pedra":
                            Console.WriteLine("Jogador 2 venceu"); break;
                            case "papel":
                            Console.WriteLine("Ambos venceram"); break;
                    }
                    break;
            }
            

        }
    }
}