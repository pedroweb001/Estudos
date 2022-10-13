using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace formatandodata
{
    class Program
    {
        static void Main()
        {
 var dataatual = DateTime.Now;           
 CultureInfo ci = new CultureInfo("pt-BR");
 Console.WriteLine("A data atual é:" + string.Format("{0:d}", dataatual.ToString(ci)));
        }
    }
}