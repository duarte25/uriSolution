using System; 

class URI {

    static void Main(string[] args) { 

        double R,pi;
      
        pi=3.14159;
        R=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("VOLUME = "+((4.0/3)*pi*(R*R*R)).ToString("f3"));
    }

}