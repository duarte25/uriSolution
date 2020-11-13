using System; 

class URI {

    static void Main(string[] args) { 

         int horas, KmH;

        horas=Convert.ToInt32(Console.ReadLine());
        KmH=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(((horas*KmH)/12.0).ToString("f3"));

    }

}