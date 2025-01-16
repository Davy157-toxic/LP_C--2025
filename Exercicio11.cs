
using System;
public class Exercicio11
{
    public static void Main(string[] args)
    {
       int soma = 1;
        int cont = 1;

        while (soma <= 100)
        {
          cont++;
            soma += cont;
            Console.WriteLine(cont+" = "+soma);
        }
        
    }
}
