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
        public Botella(string color, string material) 
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantActual = 0;
        }

        //sobrecarga de constructor
        public Botella() { }

        private int capacidad;
        private string color;
        private string material;
        private int cantActual;

        float recargar()
        {
            if(cantActual > 0)
            {
                int dif = capacidad - cantActual;
                float monto = dif * 50 / 100;
                cantActual += dif;
                return monto;
            }
            cantActual = 100;
            return 50;
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