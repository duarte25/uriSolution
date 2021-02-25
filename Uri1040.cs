using System;
using System.Globalization;
class Uri
{
    static void Main(string[] args)
    {
        double n1,n2,n3,n4,media;

        n1=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n2=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n3=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        n4=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        media = ((n1*2.0)+(n2*3.0)+(n3*4.0)+(n4))/10.0;
        Console.WriteLine("Media: "+media.ToString("F1", CultureInfo.InvariantCulture));

        if(media >= 7.0){
            Console.WriteLine("Aluno aprovado.");
        }else if(media < 5.0){
            Console.WriteLine("Aluno reprovado.");
        }else if(media >= 5.0 && media < 6.9){
            Console.WriteLine("Aluno em exame.");
            double exame=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            Console.WriteLine("Nota do exame: "+exame.ToString("F1", CultureInfo.InvariantCulture));
            exame=(exame+media)/2;
            if(exame>=5.0){
                Console.WriteLine("Aluno aprovado.");
            }else{
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine("Media final: "+exame.ToString("F1", CultureInfo.InvariantCulture));
        }


    }
}