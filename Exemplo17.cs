using System;
public class Exemplo17 
{
    public static void Main(string[] args) 
    {
        int[] IdadeAlunos = { 10 ,15, 17, 19};
        //usando for
        Console.WriteLine("Idade percorrida com for:");
        for (int contador = 0; contador < IdadeAlunos.Length; contador++) 
        {
         Console.WriteLine(IdadeAlunos[contador]);
        }
        //usando foreach
        Console.WriteLine("Idade percorrida com foreach: ");
        foreach (int idade in IdadeAlunos) 
        {
            Console.WriteLine(idade);
        }
    }
}