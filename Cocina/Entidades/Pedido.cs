using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {

        public uint id { get; set; }
        public DateTime Fecha { get; set; }

        public Dictionary<Articulo, int> articulos = new Dictionary<Articulo, int>();

        public Pedido(uint id, DateTime fecha)
        {
            this.id = id;
            Fecha = fecha;
        }

        public void AddArticulo(Articulo articulo, int cantidad)
        {
            articulos.Add(articulo,cantidad);
        }

        public decimal GetPrecioTotal()
        {
            decimal total = 0;

            foreach (var item in articulos)
            {
                total +=  item.Key.Precio*item.Value;
            }
            return total;
        }


        public override string ToString()
        {
            return $"id: {id}, fecha: {Fecha}";
        }
    }
}
