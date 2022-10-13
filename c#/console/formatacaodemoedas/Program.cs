using System;
using System.Globalization;

namespace formatacaodemoedas
{
    class Program
    {
        static void Main()
        {
  double valor = 5.00;
  NumberFormatInfo seila = new CultureInfo("pt-BR", false).NumberFormat;
Console.WriteLine(valor.ToString("c", seila));
        }
    }
}