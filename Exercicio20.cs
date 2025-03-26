using System;
using System.Runtime.InteropServices;



    public class exercicio20
    {
        public static void Main(string[] args)
        {
            // Convertendo um valor decimal para inteiro
            double valorDecimal = 2.9;
            int inteiro = Convert.ToInt32(valorDecimal);
            Console.WriteLine(inteiro);
            // Convertendo um valor longo para um numero pequeno usando casting
            long longo = 10000000000000;
            int pequeno = (int)longo;
            Console.WriteLine(pequeno);
            // Convertendo um caracter para um código ASCII
            char caracter = 'A';
            int codigo = Convert.ToInt32(caracter);
            Console.WriteLine(codigo);
            // Convertendo um numero fora do intervalo de um byte para um byte
            int numero = 282;
            byte b = (byte)numero;
            Console.WriteLine(b);
            // Convertendo um valor decimal(double) para um valor usando (float)
            double valorDouble = 100.5212412434;
            float valorFloat = (float)valorDouble;
            Console.WriteLine(valorFloat);

        }
    }
