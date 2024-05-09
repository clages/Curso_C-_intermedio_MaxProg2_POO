using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        //Atributos
        private int edad;
        private float sueldo;
        private string nombre;
        
        //Constructor de Persona con string obligatorio
        public Persona(string nombr)
        {
            this.nombre = nombr;
        }

        public int Edad { get; set; }

        public string saludo(int edad_)
        {
            return "Hola soy " + nombre + " y tengo " + edad_ + " años";
        }
    }
}
