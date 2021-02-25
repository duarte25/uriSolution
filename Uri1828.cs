using System;
class Uri
{
    static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        bool sheldon = false;
        for (int i = 1; i <= n; i++)
        {
            string[] val=Console.ReadLine().Split(' ');

            if (val[0] != val[1])
            {
                switch (val[0])
                {
                    case "pedra":
                        sheldon = val[1] == "lagarto" || val[1] == "tesoura";
                        break;
                    case "papel":
                        sheldon = val[1] == "pedra" || val[1] == "Spock";
                        break;
                    case "tesoura":
                        sheldon = val[1] == "papel" || val[1] == "lagarto";
                        break;
                    case "lagarto":
                        sheldon = val[1] == "Spock" || val[1] == "papel";
                        break;
                    case "Spock":
                        sheldon = val[1] == "tesoura" || val[1] == "pedra";
                        break;
                }
                Console.WriteLine("Caso #"+i+(sheldon ? " Bezinga" : " Raj trapaceou!"));
            }
            else 
            {
                Console.WriteLine("Caso #"+i+": De novo!");
            }
        }
    }
}