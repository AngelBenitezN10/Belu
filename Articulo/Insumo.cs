using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Insumo:Articulo
    {   

        //constructores
        public Insumo(string nombre): base(nombre) {
         
        }

        public Insumo(string nombre,decimal precio) : base(nombre,precio)
        {
            _precio = precio;

        }

        public override decimal Precio { get => _precio; }



        //metodos
        public void SetPrecio(decimal value) {
            _precio = value;
        
        }
       

    }
}
