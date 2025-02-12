using System;
public class Exercicio17
{
    public static void Main(string[] args) 
    {
        // Iniciar os arrays
        String[] filmes = { "Harry Potter","Zorro","Simpsons"};
        int[] datafilme = { 1999, 2010, 2014 };

        Console.WriteLine("Lista de filmes\n");

        // Percorre o array datafilme
        for (int contador = 0; contador < datafilme.Length;contador++)
        {
            String f = filmes[contador];
               Console.WriteLine(f + "-" + datafilme[contador]);
        }  
    }
}