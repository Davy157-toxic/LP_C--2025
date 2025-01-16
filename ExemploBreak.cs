using System;

public class exemploBreak
{

    public static void Main(string[] args)
    {
        //Loop Aninhado
        for (int contador = 1; contador <= 10; contador++)
        {
            if (contador == 5)
            {
               break;
            }
           Console.WriteLine(contador);
        }

    }
}
