using System;
public class Exercicio18 
{
    public static void Main(String[] args) 
    {
        //Abrindo arrays parea Cidades e Habitantes 
        string[] Cidade = { "Lisboa", "Porto", "Coimbra", "Faro", "Braga" };
        int[] Habitantes = { 545000, 237000, 143000, 118000, 193000 };

        Console.WriteLine("Cidades e as suas populaçãoes: ");
        //Correndo a array Habitantes 
        for (int cont = 0; cont < Habitantes.Length; cont++)
        {
            //juntando a array Cidaddes ao codigo 
            String c = Cidade[cont];
            Console.WriteLine($"{Cidade[cont]}-{Habitantes[cont]}");

        }
    }
}
