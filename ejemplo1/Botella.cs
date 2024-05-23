using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Botella
    {
        //constructor
        public Botella(string color1, string material1)
        {
            this.color = color1;
            this.material = material1;
            capacidad = 100;
            cantActual = 0;
        }

        //sobrecarga de constructor
        public Botella() { }

        private int capacidad;
        private string color;
        private string material;
        private int cantActual;

        //metodo
        public float recargar()
        {
            if (cantActual > 0)
            {
                int dif = capacidad - cantActual;
                float monto = dif * 50 / 100;
                cantActual += dif;
                return monto;
            }
            cantActual = 100;
            return 50;
        }

        //sobrecarga de metodo
        public float recargar(int cant)
        {
            cantActual += cant;
            return cant * 47.982f/100;
        }

        public string mostrar()
        {
            return "La botella es de color " + color + " material " + material + " y cantidad actual " + cantActual;
        }

        /*
        //C# Propiedad
        public int Capahi tenes todos los pedestales
        fijate el ultimoacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
        */
    }
}