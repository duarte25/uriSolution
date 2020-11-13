using System; 

class URI {

    static void Main(string[] args) { 

int entrada,min,sobra,horas,segun;

        entrada=Convert.ToInt32(Console.ReadLine());

        horas=entrada/3600;
        sobra=entrada%3600;
        min=sobra/60;
        sobra %= 60;
        segun = sobra;
        
        Console.WriteLine(horas+":"+min+":"+segun);

    }

}