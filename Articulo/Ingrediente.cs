using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Ingrediente
    {
        private decimal cantidad;
        private Insumo insumo;
        //constructor
        public Ingrediente(Insumo ins, int cantidad) {
            this.cantidad = cantidad;
            this.insumo = ins;
                
        }



        //propiedad
        public decimal Cantidad
        {

            get
            {
                return cantidad;
            }
            set
            {


                cantidad = value;

            }

        }
        public Insumo Insumo
        {

            get
            {
                return insumo;
            }
            set
            {


                insumo = value;

            }

        }

        public override string ToString()
        {
            return $"{insumo} cantidad: {Cantidad}";

        }
    }
}
