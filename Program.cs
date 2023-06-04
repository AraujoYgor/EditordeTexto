using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: Sair(); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {

        }

        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite o seu texto abaixo, e Aperte 'ESC' para sair");
            Console.WriteLine("-------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }

            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.Write(text);
        }
        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu sair...");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Salvando arquivos necessarios...");
            Thread.Sleep(800);
            Console.Clear();
            Console.WriteLine("Fechando arquivos necessarios...");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("Obrigado por usar nosso sistema, estamos anciosos pela sua volta!");
            Thread.Sleep(1000);
            Console.Clear();
            System.Environment.Exit(0);
        }
    }
}