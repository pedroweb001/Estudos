using System;
using System.IO;

namespace editordetexto
{
    class Program
    {
        static void Main()
        {
            menu();
        }

        static void menu()
        {
            Console.Clear();
            short opcao;
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1). Abrir arquivo. 2). Editar arquivo");
            Console.WriteLine("0). Sair");
            opcao = short.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    abrirarquivo();
                    break;
                case 2:
                    editararquivo();
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Main();
                    break;
            }
        }

        static void abrirarquivo()
        {
            Console.Clear();
            string path;
            Console.WriteLine("Informe o caminho do arquivo que deseja abrir:");
            path = Console.ReadLine();
            var file = new StreamReader(path);
            string text = file.ReadToEnd();
            Console.WriteLine(text);
            Console.ReadKey();
            menu();
        }

        static void editararquivo()
        {
            Console.Clear();
            string texto = "";
            Console.WriteLine("Iniciando a digitação do arquivo");
            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
                Console.Write(texto);
                FileStream.Flush
                
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            salvararquivo(texto);
        }

        static void salvararquivo(string texto)
        {
            Console.WriteLine("Informe um caminho para salvar o arquivo:");
            var path = Console.ReadLine();
            var file = new StreamWriter(path, true);
            file.Write(texto);
            file.Close();
        }
    }
}