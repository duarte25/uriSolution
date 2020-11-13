using System; 

class URI {

    static void Main(string[] args) { 

       string nome;
        double salario,vendas,total;

        nome=Console.ReadLine();
        salario=Convert.ToDouble(Console.ReadLine());
        vendas=Convert.ToDouble(Console.ReadLine());

        total=(0.15*vendas)+salario;

        Console.WriteLine("TOTAL = R$ "+total.ToString("f2"));

    }

}