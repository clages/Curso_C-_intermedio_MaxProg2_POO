using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            float sueldo;
            string nombre;
            int[] edades = new int[10];
            float[] sueldos = new float[10];
            string[] nombres = new string[10];

            //Invocar get/set de una propiedad generico
            Persona p1 = new Persona("pepe");
            p1.Edad = 20;
            var edad1 = p1.Edad;
            Console.WriteLine(p1.saludo(edad1));
            Console.WriteLine(edad1);


            Console.WriteLine("\n\nBOTELLA");
            //Invocar get/set de una propiedad modo C#
            Botella b1 = new Botella("rojo", "plastico");
            Console.WriteLine(b1.mostrar());
            float traer = b1.recargar(10);
            Console.WriteLine(b1.mostrar() + "Monto " + traer.ToString("0.00"));

            Console.WriteLine("\n\nPERRO");
            //Invocar get/set C#
            Perro pe1 = new Perro();
            pe1.Nombre = "pep";
            string respuesta = pe1.Nombre;

            Console.WriteLine(respuesta);


            Console.ReadKey();

        }
    }
}
