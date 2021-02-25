using System;
class Uri
{
    private static void Main()
    {
        string n = Console.ReadLine();

        switch (n.Length)
        {
            case 1:
                Console.WriteLine(Romano(int.Parse(n), 'u'));
                break;
            case 2:
                Console.Write(Romano(int.Parse(n[0].ToString()), 'd'));
                Console.WriteLine(Romano(int.Parse(n[1].ToString()), 'u'));
                break;
            case 3:
                Console.Write(Romano(int.Parse(n[0].ToString()), 'c'));
                Console.Write(Romano(int.Parse(n[1].ToString()), 'd'));
                Console.WriteLine(Romano(int.Parse(n[2].ToString()), 'u'));
                break;
        }
    }

    private static string Romano(int algarismo, char posicao)
    {
        switch (posicao)
        {
            case 'u':
                switch (algarismo)
                {
                    case 1:
                       return "I";
                    case 2:
                        return "II";
                    case 3:
                        return "III";
                    case 4:
                        return "IV";
                    case 5:
                        return "V";
                    case 6:
                        return "VI";
                    case 7:
                        return "VII";
                    case 8:
                        return "VIII";
                    case 9:
                        return "IX";
                    default:
                        return null;
                }
            case 'd':
                switch (algarismo)
                {
                    case 1:
                        return "X";
                    case 2:
                        return "XX";
                    case 3:
                        return "XXX";
                    case 4:
                       return "XL";
                    case 5:
                        return "L";
                    case 6:
                        return "LX";
                    case 7:
                        return "LXX";
                    case 8:
                        return "LXXX";
                    case 9:
                        return "XC";
                    default:
                        return null;
                }
            case 'c':
                switch (algarismo)
                {
                    case 1:
                        return "C";
                    case 2:
                        return "CC";
                    case 3:
                        return "CCC";
                    case 4:
                        return "CD";
                    case 5:
                        return "D";
                    case 6:
                        return "DC";
                    case 7:
                        return "DCC";
                    case 8:
                        return "DCCC";
                   case 9:
                        return "CM";
                    default:
                        return null;
                }
            default:
                return null;
            
        }
    }
}