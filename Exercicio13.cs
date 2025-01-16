using System;
public class exercicio13
{
    public static void Main(string[] args)
    {
        int contador = 0; 
        
        do
        {
            Console.WriteLine(contador);

            contador++;
        }
        while (contador <= 5);
        //Depois de chegar a 5 a leitura do console le depois do while
        Console.WriteLine("Contagem concluida");
        
    }    
}
