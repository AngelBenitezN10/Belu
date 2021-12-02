using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Insumo : Articulo
    {

        public Insumo(string nombre):base(nombre){}

        public Insumo(string nombre, decimal precio):base(nombre)
        {
            _precio = precio;
        }

        public override decimal Precio { get => _precio; }

        public void setPrecio(decimal valor)
        {
            _precio = valor;
        }


    }
}
