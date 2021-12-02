using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Producto:Articulo 
    {
        private decimal margenUtilidad;
        //constructor

        public Producto(string nombre): base(nombre)
        {
        
        }
        public Producto(string nombre, decimal margenUtilidad): base(nombre) {

            this.MargenUtilidad = margenUtilidad;
        
        
        }
        
        //propiedad
        public decimal MargenUtilidad {

            get
            {
                return margenUtilidad;
            }
            set
            {


                margenUtilidad = value;

            }

        }


        //metodos
        List<Ingrediente> ingredientes= new List<Ingrediente>();

        public void AddIngrediente(Ingrediente value)
        {
            ingredientes.Add(value);

        }


        public List<Ingrediente> GetReceta() {

            return ingredientes;
        }
        public decimal PrecioFinal() {

            decimal total = 0;
            foreach (var item in ingredientes)
            {
                total += item.Insumo.Precio * item.Cantidad;
            }

            return total * margenUtilidad / 100;
        }
        public override decimal Precio
        {


            get { return PrecioFinal(); }

        }
    }
}
