using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono = new Telefono();

            string llamado1 = telefono.Llamar();
            Console.WriteLine(llamado1);

            string llamado2 = telefono.Llamar("Pedro");
            Console.WriteLine("\n\n" + llamado2);
            Console.ReadKey();
        }
    }
}
