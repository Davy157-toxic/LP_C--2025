using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
public class Exercicio_15 
{
    public static void Main(string[] args) 
    {
        bool resultado = VddFls(1);

        if (resultado == true)
        {
            Console.WriteLine("O numnero e par");
        }
        else
        {
            Console.WriteLine("O numero e impar");
        }
    }
    static bool VddFls(int a)   
    {
        return a % 2 == 0;
    }
}
