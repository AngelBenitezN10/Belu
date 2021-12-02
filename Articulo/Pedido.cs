using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class  Pedido
    {
        private uint id;
        private DateTime fecha;
        //constructor 
        public Pedido(uint Id, DateTime Fecha) {

            this.id = Id;
            this.fecha = Fecha;
        
        }


        //propiedades
        public uint Id
        {

            get
            {
                return id;
            }
            set
            {


                id = value;

            }
        }
        

        public DateTime Fecha
        {

            get
            {
                return fecha;
            }
            set
            {


                fecha = value;

            }
        }

        //metodos
        Dictionary<Articulo, int> articulos =new Dictionary<Articulo, int>();


        public void  AddArticulo(Articulo articulo,int cantidad)
        {
            articulos.Add(articulo, cantidad);
        }

        public decimal GetPrecioTotal() {
            decimal PrecioTotal=0;
            foreach( var item  in articulos){

                PrecioTotal = item.Key.Precio * item.Value;
            }
            return PrecioTotal;
        }

        public override string ToString()
        {
            return $"{id }, {fecha}";
        }
    }
}
