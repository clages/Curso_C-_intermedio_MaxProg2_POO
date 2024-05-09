using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //primer lote 10 producto con:
            //codArticulo 3 digitos no correlativos
            //codMarca 1 a 10
            //precio

            //segundo lote 10 producto con:
            //codArticulo 3 digitos no correlativos
            //codMarca 1 a 10
            //precio

            
            string sexo = "";

            Console.WriteLine("Ingresa tu sexo M o F");
            sexo = Console.ReadLine();
            Console.WriteLine("\n\n\nSEXO: " + sexo);


            /*
           Articulo[] articulos = new Articulo[10];

           for (int i = 0; i<1; i++)
           {
               articulos[i] = new Articulo();
               Console.WriteLine("Ingrese Producto " + (i+1));
                Console.WriteLine("Codigo: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Marca: ");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                */



            // articulos[i].Precio = float.Parse(Console.ReadLine());
        }

        /*  Console.WriteLine("Datos ingresados:");
          for (int i = 0; i < 2; i++)
          {
              Console.WriteLine($"Producto {i + 1}:");
              Console.WriteLine($"Codigo: {articulos[i].CodigoArticulo}");
              Console.WriteLine($"Marca: {articulos[i].CodigoMarca}");
              Console.WriteLine($"Precio: {articulos[i].Precio}");
              Console.WriteLine();
          }

          Venta venta = new Venta();
          Console.WriteLine("Ingrese la venta:");
          Console.WriteLine("Codigo de Cliente:");
          venta.CodigoCliente = int.Parse(Console.ReadLine());


          while(venta.CodigoCliente != 0)
          {
              Console.WriteLine("Codigo de Articulo:");
              venta.CodigoArticulo = int.Parse(Console.ReadLine());
              Console.WriteLine("Cantidad");
              venta.Cantidad = int.Parse(Console.ReadLine());
              Console.WriteLine("Ingrese la venta:");
              Console.WriteLine("Codigo de Cliente:");
              venta.CodigoCliente = int.Parse(Console.ReadLine());
          }*/
    }
}
