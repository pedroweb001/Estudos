using System;
using System.Threading;

namespace cronometro
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
            string tempo;
            int mult = 1, capturarnumero;
            char tipo;
            Console.WriteLine("Deseja cronometrar em:");
            Console.WriteLine("m: minutos, ou s: segundos");
            Console.WriteLine("Exemplo: 10s");
            tempo = Console.ReadLine();
            tempo.ToLower();
            tipo = char.Parse(tempo.Substring(tempo.Length - 1, 1));
            capturarnumero = int.Parse(tempo.Substring(0, tempo.Length - 1));
            if (capturarnumero is 0)
            {
                System.Environment.Exit(0);
            }
            else
            if (tipo is 'm')
            {
                mult = 60;
                start(capturarnumero * mult);
            }
            else
            if (tipo is 's')
            {
                start(capturarnumero);
            }
        }

        static void start(int time)
        {
            Console.Clear();
            int currenttime = 0;
            while (currenttime != time)
            {
                currenttime++;
                Console.WriteLine(currenttime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Finalizado!");
            Thread.Sleep(2000);
            Main();
        }
    }
}