using System;

namespace erro
{
    class Program
    {
        static void Main()
        {
            int v1, v2, v3;
            try
            {
                Console.WriteLine("Digite o primeiro número");
                v1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                v2 = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Erro. Digite somente números!");
                Main();
                return;
                throw;
            }
            v3 = (v1+v2);
            Console.WriteLine("O resultado da soma é:" + v3);
        }
    }
}