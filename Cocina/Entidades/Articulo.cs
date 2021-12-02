using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Articulo
    {

        public string Nombre { get; set; }

        protected decimal _precio;

        public abstract decimal Precio { get; }

        public Articulo(string nombre)
        {
            Nombre = nombre;
        }

        public Articulo() { }

        public override string ToString()
        {
            return $"nombre del articulo: {Nombre}";
        }

    }
}
