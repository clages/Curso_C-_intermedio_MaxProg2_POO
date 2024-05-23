using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    class Telefono
    {

        public string marca { get; }
        public string modelo { get; }
        public string numero { get; set; }

        private int codigoOperador = 0;

        public int CodigoOperador
        {
            get { return codigoOperador; }

            set
            {
                if (value > 0 && value < 4)
                {
                    codigoOperador = value;
                }
                else codigoOperador = 0;
            }
        }

        public void Tipo (string modelo, string marca)
        {

        }

        public string Llamar()
        {
            return "Realizando llamada...";
        }

        public string Llamar(string contacto) 
        {
            return "Llamando a " + contacto + "...";
        }

    }
}
