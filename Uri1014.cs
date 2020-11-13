using System; 

class URI {

    static void Main(string[] args) { 
       int X;
            double Y, aConsumption;
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());

            aConsumption = X / Y;

            Console.WriteLine(aConsumption.ToString("f3") + " km/l");

            Console.ReadKey();
    }

}