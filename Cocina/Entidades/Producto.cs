using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : Articulo
    {

        public decimal MargenUtiliiad { get; set; }

        List<Ingrediente> ingredientes = new List<Ingrediente>();

        public Producto(string nombre) : base(nombre) { }

        public Producto(string  nombre, decimal margen):base(nombre)
        {
            MargenUtiliiad = margen;
        }
        
        private decimal CalcularPrecio()
        {
            decimal total = 0;
            foreach (var item in ingredientes)
            {
                total += item.insumo.Precio * item.Cantidad;
            }

            return total * MargenUtiliiad/100;
        }

        public override decimal Precio {


            get { return CalcularPrecio(); }
                
         }

        public List<Ingrediente> GetReceta()
        {
            return ingredientes;
        }

        public void addIngrediente(Ingrediente ingre)
        {
            ingredientes.Add(ingre);
        }
    }
}
