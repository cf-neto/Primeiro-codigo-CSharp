using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Você está em um OpenBar e temos várias opções de bebidas!");
        Console.WriteLine("Escolha uma bebida entre as seguintes opções:");
        Console.WriteLine("1. Cerveja");
        Console.WriteLine("2. Vinho");
        Console.WriteLine("3. Refrigerante");
        Console.WriteLine("4. Água");

        // Lê a mensagem, como um input
        Console.Write("Digite um número: ");
        string escolha = Console.ReadLine();

        // Resposta com base na escolha
        if (escolha == "1")
        {
            Console.WriteLine("Você pegou uma Cerveja!");
        }
        else if (escolha == "2")
        {
            Console.WriteLine("Você pegou um Vinho!");
        }
        else if (escolha == "3")
        {
            Console.WriteLine("Você pegou um Refrigerante!");
        }
        else if (escolha == "4")
        {
            Console.WriteLine("Você pegou uma Água!");
        }
        else 
        {
            Console.WriteLine("Não existe essa opção!");
        }

        Console.ReadLine();
    }
}