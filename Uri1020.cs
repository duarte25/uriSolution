using System; 

class URI {

    static void Main(string[] args) { 

         int entrada,meses,sobra,anos,dias;

        entrada=Convert.ToInt32(Console.ReadLine());

        anos=entrada/365;
        sobra=entrada%365;
        meses=sobra/30;
        sobra %= 30;
        dias = sobra;
        
        Console.WriteLine(anos+" ano(s)");
        Console.WriteLine(meses+" mes(es)");
        Console.WriteLine(dias+" dia(s)");
    }

}