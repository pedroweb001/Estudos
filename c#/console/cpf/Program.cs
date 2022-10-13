namespace cpf
{
    class Program
    {
        static void Main()
        {
            double cpf;
            Console.WriteLine("Digite seu cpf:");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("O seu cpf é:" + string.Format(@"{0:000\.000\.000\-00}", cpf));
            Console.WriteLine("O seu cpf é:" + cpf);
        }
    }
}