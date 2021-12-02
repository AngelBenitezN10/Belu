using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingrediente
    {

        public decimal Cantidad { get; set; }

        public Insumo insumo { get; set; }

        public Ingrediente(Insumo ins, decimal cantidad)
        {
            insumo = ins;

            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"{insumo} cantidad: {Cantidad}";
        }

    }
}
