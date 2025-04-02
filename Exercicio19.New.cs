using System;
using System.Collections.Generic;
public class exercicio19
{
    public static void Main(String[] args)
    {
        //Variavel global
        //Cria o dicionario 
        Dictionary<String, String> listaTelefonica = new Dictionary<String, String>();
        String opcao;
        

        do
        {
            
            
            //menu
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1. Adicionar contacto: ");
            Console.WriteLine("2.. Pesquisar contacto: ");
            Console.WriteLine("3... Remover contacto: ");
            Console.WriteLine("4.... Sair: ");

            opcao = Console.ReadLine();
            int opcao2 = Convert.ToInt32(opcao);

            //Criar a logica das opções
            switch (opcao2)
            {
                case 1:
                    Console.WriteLine("Nome: ");
                    String nome = Console.ReadLine();

                    Console.WriteLine("Contacto: ");
                    string contacto = Console.ReadLine();
                    listaTelefonica.Add(nome, contacto);

                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.WriteLine("Nome: ");
                    String nomePesquisa = Console.ReadLine();
                    if (listaTelefonica.ContainsKey(nomePesquisa))
                    {
                        Console.WriteLine($"\n Contacto: {listaTelefonica[nomePesquisa]}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Nome :");
                    nomePesquisa = Console.ReadLine();

                    if (listaTelefonica.ContainsKey(nomePesquisa))
                    {
                        listaTelefonica.Remove(nomePesquisa);
                    }
                    else
                    {
                        Console.WriteLine("Contacto não encontrado!");
                    }
                    break;

                case 4:
                    Console.WriteLine("O programa fechou...");
                    break;
                default:
                    Console.WriteLine("Opcao Invalida");
                    break;
            }

        } while (opcao != "4");

    }

} 
        

         
        

