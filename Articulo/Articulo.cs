using System;

namespace Entities
{
    public abstract class Articulo
    {
        private string nombre; 
        protected decimal _precio;
        //constructor
        public Articulo(string Nombre) {
            this.nombre = Nombre;
        }
        public Articulo(string Nombre,decimal Precio)
        {
            this._precio = Precio;
        }

        //propiedades
        public string Nombre
        {

            get
            {
                return nombre;
            }
            set
            {


                nombre = value;

            }
        }
        public abstract decimal Precio
        {

            get;
           
           
        }

        //metodos

        public override string ToString()
        {
            return $"{nombre }, {_precio}";
        }
    }
}
