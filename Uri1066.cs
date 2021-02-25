using System;

class Uri
{
    static void Main(string[] args)
    {
        int par,impar,positivo,negativo=0;
        par=0; 
        impar=0; 
        positivo=0;

        int n1=Convert.ToInt32(Console.ReadLine());
        int n2=Convert.ToInt32(Console.ReadLine());
        int n3=Convert.ToInt32(Console.ReadLine());
        int n4=Convert.ToInt32(Console.ReadLine());
        int n5=Convert.ToInt32(Console.ReadLine());

        if (n1 % 2 == 0) {
                par++;
            }
            else {
                impar++;
            }
            if (n1 > 0) {
                positivo++;
            }
            else if (n1 < 0) {
                negativo++;
            }

        if (n2 % 2 == 0) {
                par++;
            }
            else {
                impar++;
            }
            if (n2 > 0) {
                positivo++;
            }
            else if (n2 < 0) {
                negativo++;
            }
        
        if (n3 % 2 == 0) {
                par++;
            }
            else {
                impar++;
            }
            if (n3 > 0) {
                positivo++;
            }
            else if (n3 < 0) {
                negativo++;
            }

        if (n4 % 2 == 0) {
                par++;
            }
            else {
                impar++;
            }
            if (n4 > 0) {
                positivo++;
            }
            else if (n4 < 0) {
                negativo++;
            }
        
        if (n5 % 2 == 0) {
                par++;
            }
            else {
                impar++;
            }
            if (n5 > 0) {
                positivo++;
            }
            else if (n5 < 0) {
                negativo++;
            }

        Console.WriteLine(par+" valor(es) par(es)");
        Console.WriteLine(impar+" valor(es) impar(es)");
        Console.WriteLine(positivo+" valor(es) positivo(s)");
        Console.WriteLine(negativo+" valor(es) negativo(s)");
    }
}